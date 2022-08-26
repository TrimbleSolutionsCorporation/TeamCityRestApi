// --------------------------------------------------------------------------------------------------------------------
// <copyright file="IHttpSonarConnector.fs" company="Copyright © 2014 Tekla Corporation. Tekla is a Trimble Company">
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

open RestSharp
open TeamcityRestTypes

type IHttpTeamcityConnector = 
  abstract member HttpDeleteRequest : ITeamcityConfiguration * string -> RestResponse
  abstract member HttpRequest : ITeamcityConfiguration * string * Method -> RestResponse
  abstract member HttpGetRequest : ITeamcityConfiguration * string -> string
  abstract member HttpPutRequest : ITeamcityConfiguration * string * Map<string, string> -> RestResponse
  abstract member HttpPutRequest : ITeamcityConfiguration * string * string -> bool
  abstract member HttpPostRequest : ITeamcityConfiguration * string * Map<string, string> -> RestResponse
  abstract member HttpPostRequestContent : ITeamcityConfiguration * string * string -> RestResponse
  abstract member HttpPutXmlContent : ITeamcityConfiguration * string * string -> RestResponse  
  abstract member HttpPutTxtContent : ITeamcityConfiguration * string * string -> RestResponse  
  abstract member HttpPostRequestDic : ITeamcityConfiguration * string * System.Collections.Generic.Dictionary<string, string> -> RestResponse
  abstract member HttpPutFileContent : ITeamcityConfiguration * url:string * payload:string * node:string -> string

