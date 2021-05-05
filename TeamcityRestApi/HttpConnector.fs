// --------------------------------------------------------------------------------------------------------------------
// <copyright file="HttpConnector.fs" company="Copyright © 2014 Tekla Corporation. Tekla is a Trimble Company">
//     Copyright (C) 2013 [Jorge Costa, Jorge.Costa@tekla.com]
// </copyright>
// --------------------------------------------------------------------------------------------------------------------
// This program is free software; you can redistribute it and/or modify it under the terms of the GNU Lesser General Public License
// as published by the Free Software Foundation; either version 3 of the License, or (at your option) any later version.
//
// This program is distributed in the hope that it will be useful, but WITHOUT ANY WARRANTY; without even the implied warranty
// of MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE. See the GNU Lesser General Public License for more details. 
// You should have received a copy of the GNU Lesser General Public License along with this program; if not, write to the Free
// Software Foundation, Inc., 59 Temple Place, Suite 330, Boston, MA 02111-1307 USA
// --------------------------------------------------------------------------------------------------------------------
namespace TeamcityRestConnector

open TeamcityRestTypes
open System.IO
open System
open System.Net
open System.Text
open RestSharp
open RestSharp.Authenticators
open System.Threading

type JsonTeamcityConnector() = 
    let mutable sessionCookie = null

    let toMap dictionary = 
        (dictionary :> seq<_>)
        |> Seq.map (|KeyValue|)
        |> Map.ofSeq

    let GetSessionCookie(userconf : ITeamcityConfiguration) =
        if sessionCookie = null then
            let client = new RestClient(userconf.Hostname)
            client.Timeout <- 250000
            if userconf.Token <> "" then
                client.Authenticator <- new JwtAuthenticator(userconf.Token)
            else
                client.Authenticator <- new HttpBasicAuthenticator(userconf.Username, userconf.Password)

            let request = new RestRequest("/app/rest/users", Method.GET)
            request.RequestFormat <- DataFormat.Json
            let reply = client.Execute(request)
            let sessionsCookie =
                reply.Cookies
                |> List.ofSeq
                |> Seq.tryFind (fun cookie -> cookie.Name = "TCSESSIONID")
        
            match sessionsCookie with
            | Some cookie -> sessionCookie <- cookie
            | _ -> ()

    let DoRestRequest(userConf : ITeamcityConfiguration,
                      url : string,
                      methodin : Method,
                      data : Map<string, string>) =
        GetSessionCookie(userConf)
        let client = new RestClient(userConf.Hostname)
        let request = new RestRequest(url, methodin)
        client.Timeout <- 250000
        if sessionCookie = null then
            if userConf.Token <> "" then
                client.Authenticator <- new JwtAuthenticator(userConf.Token)
            else
                client.Authenticator <- new HttpBasicAuthenticator(userConf.Username, userConf.Password)
        else
            request.AddCookie(sessionCookie.Name, sessionCookie.Value) |> ignore
        request.AddHeader("Origin", "http://teamcity") |> ignore
        data |> Seq.iter (fun elem -> request.AddParameter(elem.Key, elem.Value) |> ignore)
        request.RequestFormat <- DataFormat.Json
        client.Execute(request)

    interface IHttpTeamcityConnector with

        member this.HttpRequest(userconf : ITeamcityConfiguration, urltosue : string, methodin : Method) =
            let reply = DoRestRequest(userconf, urltosue, methodin, Map.empty)
            if reply.StatusCode <> HttpStatusCode.OK && reply.StatusCode <> HttpStatusCode.NoContent then
                sessionCookie <- null
                DoRestRequest(userconf, urltosue, methodin, Map.empty)
            else
                reply

        member this.HttpGetRequest(userConf : ITeamcityConfiguration, url : string) =
            GetSessionCookie(userConf) 
            let client = new RestClient(userConf.Hostname)
            client.Timeout <- 250000
            let request = new RestRequest(url, Method.GET)
            if sessionCookie = null then
                if userConf.Token <> "" then
                    client.Authenticator <- new JwtAuthenticator(userConf.Token)
                else
                    client.Authenticator <- new HttpBasicAuthenticator(userConf.Username, userConf.Password)
            else
                request.AddCookie(sessionCookie.Name, sessionCookie.Value) |> ignore
            request.AddHeader("Accept", "application/xml") |> ignore
            client.Execute(request).Content

        member this.HttpDeleteRequest(userConf : ITeamcityConfiguration, url : string) =
            (this :> IHttpTeamcityConnector).HttpRequest(userConf, url, Method.DELETE)

        member this.HttpPutFileContent(userConf : ITeamcityConfiguration,
                                       url : string,
                                       payload : string,
                                       node:string) =
            let req = HttpWebRequest.Create(userConf.Hostname + url) :?> HttpWebRequest 
            req.Method <- "POST"
            req.ContentType <- "application/xml"
            let auth =
                if userConf.Token <> "" then
                    "Bearer " + (userConf.Token |> Encoding.UTF8.GetBytes |> Convert.ToBase64String)
                else
                    "Basic " + (userConf.Username + ":" + userConf.Password |> Encoding.UTF8.GetBytes |> Convert.ToBase64String)

            req.Headers.Add("Authorization", auth)
            let array = Encoding.ASCII.GetBytes(payload)
            req.ContentLength <- int64(array.Length)
            let objRequestStream = req.GetRequestStream()
            objRequestStream.Write(array, 0, array.Length)
            objRequestStream.Close()

            let rsp = req.GetResponse()
            use stream = rsp.GetResponseStream()
            use reader = new StreamReader(stream)
            let data = reader.ReadToEnd()
            data

        member this.HttpPutRequest(userConf : ITeamcityConfiguration, url : string, data : Map<string, string>) =
            let reply = DoRestRequest(userConf, url, Method.PUT, data)
            if reply.StatusCode <> HttpStatusCode.OK then
                sessionCookie <- null
                DoRestRequest(userConf, url, Method.PUT, data)
            else
                reply

        member this.HttpPutRequest(userconf : ITeamcityConfiguration, url : string, data : string) =
            let client = new System.Net.WebClient()
            GetSessionCookie(userconf)            
            client.Headers.Add("Origin: http://teamcity") |> ignore
            if sessionCookie = null then
                let credentials = Convert.ToBase64String(Encoding.ASCII.GetBytes(userconf.Username + ":" + userconf.Password))
                if userconf.Token <> "" then
                    client.Headers.[HttpRequestHeader.Authorization] <- sprintf "Bearer %s" (Convert.ToBase64String(Encoding.ASCII.GetBytes(userconf.Token)))
                else
                    client.Headers.[HttpRequestHeader.Authorization] <- sprintf "Basic %s" credentials
            else
                let cookie = sprintf "TCSESSIONID=%s" sessionCookie.Value
                client.Headers.Add(HttpRequestHeader.Cookie, cookie) |> ignore

            let bytes = Encoding.UTF8.GetBytes(data)
            try
                client.UploadData(userconf.Hostname + url,"PUT", bytes) |> ignore
                true
            with
            | ex -> false

        member this.HttpPostRequest(userConf : ITeamcityConfiguration, url : string, data : Map<string, string>) =
            let reply = DoRestRequest(userConf, url, Method.PUT, data)
            if reply.StatusCode <> HttpStatusCode.OK then
                sessionCookie <- null
                DoRestRequest(userConf, url, Method.POST, data)
            else
                reply

        member this.HttpPutXmlContent(userConf : ITeamcityConfiguration, url : string, xmlData : string) =
            let client = new RestClient(userConf.Hostname)
            client.Timeout <- 250000
            if userConf.Token <> "" then
                client.Authenticator <- new JwtAuthenticator(userConf.Token)
            else
                client.Authenticator <- new HttpBasicAuthenticator(userConf.Username, userConf.Password)
            let request = new RestRequest(url, Method.PUT)
            request.AddHeader("Accept", "application/xml") |> ignore
            request.Parameters.Clear()
            request.AddParameter("application/xml", xmlData, ParameterType.RequestBody) |> ignore
            let result = client.Execute(request)
            result

        member this.HttpPutTxtContent(userConf : ITeamcityConfiguration, url : string, txtData : string) =
            let client = new RestClient(userConf.Hostname)
            client.Timeout <- 250000
            if userConf.Token <> "" then
                client.Authenticator <- new JwtAuthenticator(userConf.Token)
            else
                client.Authenticator <- new HttpBasicAuthenticator(userConf.Username, userConf.Password)
            let request = new RestRequest(url, Method.PUT)
            request.AddHeader("Origin", "http://teamcity") |> ignore
            request.AddHeader("Content-Type", "text/plain") |> ignore
            request.AddHeader("Accept", "*/*") |> ignore
            request.AddParameter("text/plain", txtData, ParameterType.RequestBody) |> ignore
            let result = client.Execute(request)
            result

        member this.HttpPostRequestContent(userConf : ITeamcityConfiguration, url : string, data : string) =
            let client = new RestClient(userConf.Hostname)
            client.Timeout <- 250000
            if userConf.Token <> "" then
                client.Authenticator <- new JwtAuthenticator(userConf.Token)
            else
                client.Authenticator <- new HttpBasicAuthenticator(userConf.Username, userConf.Password)
            let request = new RestRequest(url, Method.POST)
            request.AddHeader("Accept", "application/xml") |> ignore
            request.Parameters.Clear()
            request.AddParameter("application/xml", data, ParameterType.RequestBody) |> ignore
            let result = client.Execute(request)
            result

        member this.HttpPostRequestDic(userConf : ITeamcityConfiguration,
                                       url : string,
                                       data : System.Collections.Generic.Dictionary<string, string>) =
            let reply = DoRestRequest(userConf, url, Method.POST, toMap data)
            if reply.StatusCode <> HttpStatusCode.OK then
                sessionCookie <- null
                DoRestRequest(userConf, url, Method.POST, toMap data)
            else
                reply



