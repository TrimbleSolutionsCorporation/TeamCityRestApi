namespace TeamcityRestConnector

open System
open System.Threading
open System.Net
open TeamcityTypes
open System.Globalization
open TeamcityRestTypes

type MuteResolution = Automatic | Manual | AtTime

type ITeamcityConnector = 
  abstract member GetAllProjects : ConnectionConfiguration:ITeamcityConfiguration * buildConfig:string -> TcProject
  
  abstract member GetAllUsers : ConnectionConfiguration:ITeamcityConfiguration -> System.Collections.Generic.List<TcUser>
  abstract member GetUserByDisplayName : ConnectionConfiguration:ITeamcityConfiguration * name:string -> TcUser
  abstract member GetUserByEmail : ConnectionConfiguration:ITeamcityConfiguration * email:string -> TcUser
  abstract member GetUserById : ConnectionConfiguration:ITeamcityConfiguration * id:string -> TcUser
  abstract member GetUserByUserName : ConnectionConfiguration:ITeamcityConfiguration * username:string -> TcUser

  abstract member DeleteBuildById : ConnectionConfiguration:ITeamcityConfiguration * id:string -> bool
  abstract member GetBuildById : ConnectionConfiguration:ITeamcityConfiguration * id:string -> TcBuild
  abstract member GetBuildById : ConnectionConfiguration:ITeamcityConfiguration * id:string * getAllChanges:bool -> TcBuild
  abstract member GetBuildById : ConnectionConfiguration:ITeamcityConfiguration * id:string * getAllChanges:bool * getTests:bool -> TcBuild
  abstract member GetBuildById : ConnectionConfiguration:ITeamcityConfiguration * id:string * getAllChanges:bool * getTests:bool * getArtifcats:bool -> TcBuild
  abstract member GetBuildById : ConnectionConfiguration:ITeamcityConfiguration * id:string * getAllChanges:bool * getTests:bool * getArtifcats:bool * getResultingProps:bool -> TcBuild
  abstract member GetBuildById : ConnectionConfiguration:ITeamcityConfiguration * id:string * getAllChanges:bool * getTests:bool * getArtifcats:bool * getResultingProps:bool * getProblems:bool-> TcBuild
  
  abstract member GetBuildsBranch : ConnectionConfiguration:ITeamcityConfiguration * buildConf:TCBuildConfigurationType * nmbBuild:int * branch:string * skipChanges:bool -> System.Collections.Generic.List<TcBuild>
  abstract member GetBuildsBranch : ConnectionConfiguration:ITeamcityConfiguration * buildConf:TCBuildConfigurationType * nmbBuild:int * branch:string * skipChanges:bool * getartifacts:bool -> System.Collections.Generic.List<TcBuild>
  abstract member GetBuildsBranch : ConnectionConfiguration:ITeamcityConfiguration * buildConf:TCBuildConfigurationType * nmbBuild:int * branch:string * skipChanges:bool * getartifacts:bool * getResultProps:bool -> System.Collections.Generic.List<TcBuild>

  abstract member GetBuildsBranch : ConnectionConfiguration:ITeamcityConfiguration * buildConfId:string * nmbBuild:int * branch:string * skipChanges:bool -> System.Collections.Generic.List<TcBuild>
  abstract member GetBuildsBranch : ConnectionConfiguration:ITeamcityConfiguration * buildConfId:string * nmbBuild:int * branch:string * skipChanges:bool * getartifacts:bool -> System.Collections.Generic.List<TcBuild>
  abstract member GetBuildsBranch : ConnectionConfiguration:ITeamcityConfiguration * buildConfId:string * nmbBuild:int * branch:string * skipChanges:bool * getartifacts:bool * getResultProps:bool -> System.Collections.Generic.List<TcBuild>
  abstract member GetBuildsBranch : ConnectionConfiguration:ITeamcityConfiguration * buildConfId:string * nmbBuild:int * branch:string * skipChanges:bool * getartifacts:bool * getResultProps:bool * getTests:bool -> System.Collections.Generic.List<TcBuild>
  abstract member GetBuildsBranch : ConnectionConfiguration:ITeamcityConfiguration * buildConfId:string * nmbBuild:int * branch:string * skipChanges:bool * getartifacts:bool * getResultProps:bool * getTests:bool * getProblems:bool -> System.Collections.Generic.List<TcBuild>
  
  abstract member GetBuildsFromBuildCondiguration : ConnectionConfiguration:ITeamcityConfiguration * buildConf:string * branch:string -> System.Collections.Generic.List<TcBuild>
  abstract member GetBuildsFromBuildCondiguration : ConnectionConfiguration:ITeamcityConfiguration * buildConf:string * branch:string * detailedChagnes:bool -> System.Collections.Generic.List<TcBuild>  
  abstract member GetBuildsFromBuildCondiguration : ConnectionConfiguration:ITeamcityConfiguration * buildConf:string * branch:string * detailedChagnes:bool * getTests:bool -> System.Collections.Generic.List<TcBuild>  
  abstract member GetBuildsFromBuildCondiguration : ConnectionConfiguration:ITeamcityConfiguration * buildConf:string * branch:string * detailedChagnes:bool * getTests:bool * lookupLimit:int -> System.Collections.Generic.List<TcBuild>  
  abstract member GetBuildsFromBuildCondiguration : ConnectionConfiguration:ITeamcityConfiguration * buildConf:string * branch:string * detailedChagnes:bool * getTests:bool * lookupLimit:int * retResultProps:bool -> System.Collections.Generic.List<TcBuild>  

  abstract member GetFailedBuildsFromProject : ConnectionConfiguration:ITeamcityConfiguration * ProjectName:string * ProjectName:string -> System.Collections.Generic.List<TcBuild>
  abstract member GetFailedBuildsFromProjectFaster : ConnectionConfiguration:ITeamcityConfiguration * ProjectName:string * ProjectName:string -> System.Collections.Generic.List<TcBuild>  
  abstract member GetBuildsFromProjectFaster : ConnectionConfiguration:ITeamcityConfiguration * ProjectName:string * ProjectName:string -> System.Collections.Generic.List<TcBuild>  
  abstract member GetFailedBuildsFromConfiguration : ConnectionConfiguration:ITeamcityConfiguration * ProjectName:string * ProjectName:string -> System.Collections.Generic.List<TcBuild>

  abstract member DownloadArtifact : ConnectionConfiguration:ITeamcityConfiguration * build:TcBuild * artifactpath:string * outFile:string * useDisk:bool -> unit
  abstract member Authenticate : ConnectionConfiguration:ITeamcityConfiguration -> string
  abstract member GetLog : ConnectionConfiguration:ITeamcityConfiguration * id:int -> string
  abstract member TriggerTeamcityBuild : ConnectionConfiguration:ITeamcityConfiguration * build:TcBuild * branch:string -> unit
  abstract member TriggerTeamcityBuild : ConnectionConfiguration:ITeamcityConfiguration * build:string * branch:string * comment:string * parameters:System.Collections.Generic.Dictionary<string, string> -> string * string
  abstract member TriggerTeamcityBuild : ConnectionConfiguration:ITeamcityConfiguration * build:string * branch:string * comment:string * parameters:System.Collections.Generic.Dictionary<string, string> * agentid:string * attop:bool -> string * string
  abstract member TriggerTeamcityBuildConfiguration : ConnectionConfiguration:ITeamcityConfiguration * build:TCBuildConfigurationType * branch:string * comment:string * tags:System.Collections.Generic.IList<string> * arguments:System.Collections.Generic.Dictionary<string, string> -> unit
  abstract member TriggerTeamcityBuildConfiguration : ConnectionConfiguration:ITeamcityConfiguration * build:TCBuildConfigurationType * branch:string * comment:string * tags:System.Collections.Generic.IList<string> * arguments:System.Collections.Generic.Dictionary<string, string> * agentid:string * attop:bool -> unit  
  abstract member GetQueuedBuilds : ConnectionConfiguration:ITeamcityConfiguration -> System.Collections.Generic.List<QueueBuild>
  abstract member TriggerCheckForChanges : ConnectionConfiguration:ITeamcityConfiguration * vcsRootId:string -> unit
  abstract member GetLastRunningBuildForConfig : builds:System.Collections.Generic.List<TcBuild> * platform:string  * config:string-> TcBuild
  abstract member CreateBuildConfiguration : ConnectionConfiguration:ITeamcityConfiguration * buildConfigurationJson:string -> HttpStatusCode
  abstract member CreateNewProject : ConnectionConfiguration:ITeamcityConfiguration * name:string * id:string * parent:string -> TcProject
  abstract member GetBuildConfiguration : ConnectionConfiguration:ITeamcityConfiguration * id:string -> string
  abstract member DeleteConfiguration : ConnectionConfiguration:ITeamcityConfiguration * id:string -> bool
  abstract member DeleteProject : ConnectionConfiguration:ITeamcityConfiguration * id:string -> bool
  abstract member CancelBuild : ConnectionConfiguration:ITeamcityConfiguration * buildUrl:string * readInToQueue:bool -> bool
  abstract member MuteTest : ConnectionConfiguration:ITeamcityConfiguration * scopeId:string * reason:string * resolutionType:MuteResolution * testName:string -> bool
  abstract member GetAgents : ConnectionConfiguration:ITeamcityConfiguration * bool -> System.Collections.Generic.List<TcAgent>
  abstract member DisableAgent : ConnectionConfiguration:ITeamcityConfiguration * id:string -> bool
  abstract member EnableAgent : ConnectionConfiguration:ITeamcityConfiguration * id:string -> bool

type TeamcityConnector(httpconnector : IHttpTeamcityConnector, downloadConnection : IDownloadRestConnector) = 
    let httpconnector = httpconnector
    let downloadConnection = downloadConnection
    let mutable data = ""
    let mutable tags = ""

    let ParseDate(datestring:string) =
        let dateWithoutLocale = 
            if datestring.Contains("+") then
                datestring.Split('+').[0]
            else
                datestring

        try DateTime.ParseExact(dateWithoutLocale, "yyyyMMddTHHmmss", CultureInfo.InvariantCulture) with | _ -> DateTime.Now

    let GetTests(build:TcBuild, conf:ITeamcityConfiguration) =
        let buildurltests = sprintf "/app/rest/testOccurrences?locator=build:id:%s" build.Id
        let tests = TestResponse.Parse(httpconnector.HttpRequest(conf, buildurltests, RestSharp.Method.GET).Content)
        try
            if tests.Count > 0 then
                        for test in tests.TestOccurrence do
                        let newTest = new TcTest()
                        newTest.Id <- test.Id
                        newTest.Name <- test.Name
                        newTest.Duration <- try test.Duration with | ex -> 0
                        newTest.Muted <- try test.Muted with | ex -> try test.CurrentlyMuted with | ex -> false
                        newTest.CurrentlyInvestigated <- try test.CurrentlyInvestigated with | ex -> false
                        newTest.CurrentlyMuted <- try test.CurrentlyMuted with | ex -> false
                        newTest.Status <- test.Status
                        newTest.Href <- test.Href

                        if test.Status = "FAILURE" then
                            let buildfortestdetails = test.Href
                            let testDetails = TestDetailsJson.Parse(httpconnector.HttpRequest(conf, buildfortestdetails, RestSharp.Method.GET).Content)
                            newTest.FailureDetails <- testDetails.Details
                            if newTest.Muted then
                                try
                                    let muteInfo = MuteDetails()
                                    muteInfo.Href <- testDetails.Mute.Href
                                    muteInfo.Name <- testDetails.Mute.Assignment.User.Name
                                    muteInfo.UserName <- testDetails.Mute.Assignment.User.Username
                                    muteInfo.Text <- testDetails.Mute.Assignment.Text
                                    newTest.MuteInformation <- muteInfo
                                with
                                | ex -> newTest.Muted <- false

                            try
                                let firstFailure = TcTest()
                                firstFailure.Href <- testDetails.FirstFailed.Href
                                firstFailure.Id <- testDetails.FirstFailed.Id
                                firstFailure.Status <- testDetails.FirstFailed.Status
                                firstFailure.Name <- testDetails.FirstFailed.Name
                                newTest.FirstFailure <- firstFailure
                            with
                            | ex -> ()
                        build.Tests.Add(newTest)
        with | ex -> ()

    let GetProblems(build:TcBuild,conf:ITeamcityConfiguration)=
        let buildurlProblems= sprintf "/app/rest/problemOccurrences?locator=build:id:%s" build.Id
        let problems = ProblemOccurancesResponse.Parse(httpconnector.HttpRequest(conf, buildurlProblems, RestSharp.Method.GET).Content)
        try
           if problems.Count > 0 then
               for problem in problems.ProblemOccurrence do
                   let newProblem = new TcProblem()
                   newProblem.Id <- problem.Id
                   newProblem.Type <- problem.Type
                   newProblem.Identity <- problem.Identity
                   newProblem.Href <- problem.Href
                   let problemDetailedinfo = ProblemOccurancesDetailsResponse.Parse(httpconnector.HttpRequest(conf, problem.Href, RestSharp.Method.GET).Content)
                   newProblem.Details <- try problemDetailedinfo.Details with | ex -> ""
                   newProblem.AdditionalData <- try problemDetailedinfo.AdditionalData with | ex -> ""
                   build.Problems.Add(newProblem)
        with | ex -> ()

    let GetResultingProps(build:TcBuild,conf:ITeamcityConfiguration)=
        try
        let buildurlResultingProps = build.Href + "/resulting-properties"
        let resultingProps = ResultingProperties.Parse(httpconnector.HttpRequest(conf, buildurlResultingProps, RestSharp.Method.GET).Content)
        for prop in resultingProps.Property do
            let propToBuild = BuildProperty()
            propToBuild.Name <- prop.Name
            propToBuild.Value <- prop.Value
            build.ResultingProperties.Add(propToBuild)
        with ex -> ()

    let toMap dictionary = 
        (dictionary :> seq<_>)
        |> Seq.map (|KeyValue|)
        |> Map.ofSeq

    let getMutePayload(username:string, reason:string, test:string, resolution:MuteResolution, scopeid:string) =
        let resType =
            match resolution with
            | MuteResolution.Manual -> "manually"
            | MuteResolution.Automatic -> "whenFixed"
            | MuteResolution.AtTime -> "atTime"

        let payload = sprintf """
            <mute>
            <assignment>
                <user username="%s" name="%s"/>
                <text>%s</text>
            </assignment>
            <scope>
                <project id="%s"/>
            </scope>
            <target>
                <tests count="1">
                    <test name="%s"/>
                </tests>
            </target>
            <resolution type="%s"/>
            </mute> """ username username reason scopeid test resType

        payload

    let getPayloadXml(branch:string, buildid:string, comment:string, agent:string, atTop:bool)  = 
        let queueAtTop =
            if atTop then
                sprintf """<triggeringOptions queueAtTop="true"/>"""
            else
                ""

        let agentBuild = 
            if agent <> "" then
                sprintf """<agent id="%s"/>""" agent
            else
                ""

        if branch <> "" then
            sprintf """
                            <build branchName="%s">
                                %s
                                <buildType id="%s"/>
                                <comment><text>%s</text></comment>
                                %s
                            </build> """ (branch) queueAtTop buildid comment agentBuild
        else
            sprintf """
                            <build>
                                %s
                                <buildType id="%s"/>
                                <comment><text>%s</text></comment>
                                %s
                            </build> """ queueAtTop buildid comment agentBuild

    let getTagPayload(tagsdata:System.Collections.Generic.IList<string>) =
        tags <- ""
        if tagsdata.Count > 0 then
            tags <- sprintf """<tags count="%i"> """ tagsdata.Count
            tagsdata |> Seq.iter (fun value -> tags  <- tags + (sprintf """    <tag name="%s"/> """ value))
            tags <- tags + """</tags> """

        tags

    let getPayloadWithParametersXml(branch:string, buildid:string, comment:string, properties : Map<string,string>, agent:string, atTop:bool)  = 
        let queueAtTop =
            if atTop then
                sprintf """<triggeringOptions queueAtTop="true"/>"""
            else
                ""

        let agentBuild = 
            if agent <> "" then
                sprintf """<agent id="%s"/>""" agent
            else
                ""

        let parameters = 
            if properties.Count <> 0 then
                data <- """    <properties> """
                properties |> Map.iter (fun key value -> data  <- data + (sprintf """        <property name="%s" value="%s"/> """ key value))
                data <- data + """    </properties> """

            data

        let payload = 
            if branch <> "" then
                sprintf """
                                <build branchName="%s">
                                    %s
                                    <buildType id="%s"/>
                                    <comment><text>%s</text></comment>
                                    %s%s
                                </build> """ (branch) queueAtTop buildid comment agentBuild parameters
            else
                sprintf """
                                <build>
                                    %s
                                    <buildType id="%s"/>
                                    <comment><text>%s</text></comment>
                                    %s%s
                                </build> """ queueAtTop buildid comment agentBuild parameters
        payload


    let GetProjectsFromReply(jsonContent:string, conf:ITeamcityConfiguration) = 
            let data = ProjectResponseTags.Parse(jsonContent)

            let rootProject = new TcProject()
            rootProject.Name <- data.Name
            rootProject.Id <- data.Id
            rootProject.WebUrl <- data.WebUrl
            rootProject.Href <- data.Href


            let rec getProjectFromProjectAnswer(outProject : TcProject, project:ProjectResponseTags.Project) = 
                let data = ProjectResponseTags.Parse(httpconnector.HttpRequest(conf, outProject.Href, RestSharp.Method.GET).Content)
                
                if data.BuildTypes.Count > 0 then
                    for buildType in data.BuildTypes.BuildType do
                        let newConfig = new TCBuildConfigurationType()
                        newConfig.Name <- buildType.Name
                        newConfig.ParentProjectId <- buildType.ProjectId
                        newConfig.ProjectName <- buildType.ProjectName
                        newConfig.Id <- buildType.Id
                        newConfig.WebUrl <- buildType.WebUrl
                        newConfig.Href <- buildType.Href
                        let datax = BuildTypeResponse.Parse(httpconnector.HttpRequest(conf, newConfig.Href, RestSharp.Method.GET).Content)
                        newConfig.BuildIdRef <- datax.Builds.Href
                        outProject.BuildConfigurationTypes.Add(newConfig)

                if data.Projects.Count > 0 then
                    for proj in data.Projects.Project do
                        let newp = new TcProject()
                        newp.Name <- proj.Name
                        if not(obj.ReferenceEquals(proj.ParentProjectId, null)) then
                            newp.ParentProjectId <- proj.ParentProjectId
                        try newp.Description <- proj.Description with | ex -> ()
                        newp.Id <- proj.Id
                        newp.WebUrl <- proj.WebUrl
                        newp.Href <- proj.Href
                        outProject.Projects.Add(newp)
                        getProjectFromProjectAnswer(newp, project)   

            if data.BuildTypes.Count > 0 then
                for buildType in data.BuildTypes.BuildType do
                    let newConfig = new TCBuildConfigurationType()
                    newConfig.Name <- buildType.Name
                    newConfig.ParentProjectId <- buildType.ProjectId
                    newConfig.ProjectName <- buildType.ProjectName
                    newConfig.Id <- buildType.Id
                    newConfig.WebUrl <- buildType.WebUrl
                    newConfig.Href <- buildType.Href
                    rootProject.BuildConfigurationTypes.Add(newConfig)

            if data.Projects.Count > 0 then
                for proj in data.Projects.Project do
                    let newp = new TcProject()
                    newp.Name <- proj.Name
                    if not(obj.ReferenceEquals(proj.ParentProjectId, null)) then
                        newp.ParentProjectId <- proj.ParentProjectId

                    try newp.Description <- proj.Description with | ex -> ()
                    newp.Id <- proj.Id
                    newp.WebUrl <- proj.WebUrl
                    newp.Href <- proj.Href
                    rootProject.Projects.Add(newp)
                    getProjectFromProjectAnswer(newp, proj)

            rootProject

    interface ITeamcityConnector with
        member this.EnableAgent(conf:ITeamcityConfiguration, id:string) =
            let url = sprintf "/app/rest/agents/id:%s/enabled" id
            httpconnector.HttpPutRequest(conf, url, "true")

        member this.DisableAgent(conf:ITeamcityConfiguration, id:string) =
            let url = sprintf "/app/rest/agents/id:%s/enabled" id
            let requestDAta = httpconnector.HttpPutRequest(conf, url, "false")
            requestDAta

        member this.GetAgents(conf:ITeamcityConfiguration, details:bool) =
            let url = "/app/rest/agents"
            let reply = httpconnector.HttpRequest(conf, url, RestSharp.Method.GET).Content
            let dataParsed = AgentsResponse.Parse(reply)
            let agents = new System.Collections.Generic.List<TcAgent>()
            for agent in dataParsed.Agent do
                let agentNew = TcAgent()
                agentNew.Name <- agent.Name
                agentNew.Id <- agent.Id
                agentNew.Href <- agent.Href
                if details then
                    let replyDetails = httpconnector.HttpRequest(conf, agent.Href, RestSharp.Method.GET).Content
                    let dataParsedDetails = AgentDetails.Parse(replyDetails)
                    for prop in dataParsedDetails.Properties.Property do
                        if prop.Value.String.IsSome then
                            agentNew.Properties.Add(prop.Name, prop.Value.String.Value)
                        else
                            agentNew.Properties.Add(prop.Name, "")

                agents.Add(agentNew)
            agents

        member this.MuteTest(conf:ITeamcityConfiguration, scopeId:string, reasonTxt:string, resolution:MuteResolution, testName:string) = 
            let payload = getMutePayload(conf.Username, reasonTxt, testName, resolution, scopeId)
            let url = "/app/rest/mutes"
            httpconnector.HttpPostRequestContent(conf, url, payload).StatusCode = HttpStatusCode.OK

        member this.CancelBuild(conf:ITeamcityConfiguration, buildUrl:string, requeue:bool) = 
            let content = sprintf "<buildCancelRequest comment='Retrigger' readdIntoQueue='false' />"
            httpconnector.HttpPostRequestContent(conf, buildUrl, content).StatusCode = HttpStatusCode.OK

        member this.CreateNewProject(conf:ITeamcityConfiguration, name:string, id:string, parent:string) = 
            let url = "/httpAuth/app/rest/projects"
            let content = sprintf "<newProjectDescription name='%s' id='%s'><parentProject locator='id:%s'/></newProjectDescription>" name id parent
            let project = GetProjectsFromReply(httpconnector.HttpPostRequestContent(conf, url, content).Content, conf)
            project.ParentProjectId <- parent
            project

        member this.DeleteConfiguration(conf:ITeamcityConfiguration, content:string) = 
            let url = "/app/rest/buildTypes/id:" + content
            httpconnector.HttpDeleteRequest(conf, url).StatusCode = HttpStatusCode.OK

        member this.DeleteProject(conf:ITeamcityConfiguration, content:string) = 
            let url = "/app/rest/projects/id:" + content
            httpconnector.HttpDeleteRequest(conf, url).StatusCode = HttpStatusCode.OK

        member this.GetBuildConfiguration(conf:ITeamcityConfiguration, buildId:string) = 
            let url = "/app/rest/buildTypes/id:" + buildId
            httpconnector.HttpGetRequest(conf, url)

        member this.CreateBuildConfiguration(conf:ITeamcityConfiguration, content:string) = 
            let url = "/httpAuth/app/rest/buildTypes"
            httpconnector.HttpPostRequestContent(conf, url, content).StatusCode

        member this.TriggerCheckForChanges(conf:ITeamcityConfiguration, vcsRootId:string) = 
            let url = "/app/rest/debug/vcsCheckingForChangesQueue?locator=vcsRoot:"
            httpconnector.HttpRequest(conf, url, RestSharp.Method.GET) |> ignore

        member this.GetQueuedBuilds(conf:ITeamcityConfiguration) =
            let queuedbuilds = new System.Collections.Generic.List<QueueBuild>()
            let url = "/app/rest/buildQueue"
            let dataParsed = QueuedBuildResponse.Parse(httpconnector.HttpRequest(conf, url, RestSharp.Method.GET).Content)
            for data in dataParsed.Build do
                let newqueue = new QueueBuild()
                newqueue.BuildTypeId <- data.BuildTypeId
                if not(obj.ReferenceEquals(data.BranchName, null)) then
                    newqueue.BranchName <- data.BranchName.Value
                if not(obj.ReferenceEquals(data.DefaultBranch, null)) then
                    newqueue.DefaultBranch <- data.DefaultBranch.Value

                //newqueue.BranchName <- try data.BranchName.Value with | ex -> ""
                //newqueue.DefaultBranch <- try data.DefaultBranch.Value with | ex -> false
                newqueue.Href <- data.Href
                newqueue.State <- data.State
                if not(obj.ReferenceEquals(data.TaskId, null)) then
                    newqueue.TaskId <- data.TaskId.Value

                newqueue.WebUrl <- data.WebUrl
                queuedbuilds.Add(newqueue)
            queuedbuilds
            
        member this.TriggerTeamcityBuild(conf:ITeamcityConfiguration, build:TcBuild, branch:string) =
            let url = "/httpAuth/app/rest/buildQueue"
            let payload = getPayloadXml(branch, build.BuildTypeId, "remote trigger teamcity configuration : BuildAllUi", "", false)
            httpconnector.HttpPutFileContent(conf, url, payload, "build") |> ignore

        member this.TriggerTeamcityBuild(conf:ITeamcityConfiguration,
                                         build:string,
                                         branch:string,
                                         comment:string,
                                         parameters:System.Collections.Generic.Dictionary<string, string>) =
                (this :> ITeamcityConnector).TriggerTeamcityBuild(conf, build, branch, comment, parameters, "", false)

        member this.TriggerTeamcityBuild(conf:ITeamcityConfiguration,
                                         build:string,
                                         branch:string,
                                         comment:string,
                                         parameters:System.Collections.Generic.Dictionary<string, string>,
                                         agentString:string,
                                         attop:bool) =
            let url = "/httpAuth/app/rest/buildQueue"
            let payload = getPayloadWithParametersXml(branch, build, comment,  toMap parameters, agentString, attop)
            let returnData = httpconnector.HttpPutFileContent(conf, url, payload, "build")
            let builData = TriggerBuildResponse.Parse(returnData) 
            builData.WebUrl, builData.Href

        member this.TriggerTeamcityBuildConfiguration(conf:ITeamcityConfiguration,
                                                      build:TCBuildConfigurationType,
                                                      branch:string,
                                                      comment:string,
                                                      tags:System.Collections.Generic.IList<string>,
                                                      arguments : System.Collections.Generic.Dictionary<string, string>) =
            (this :> ITeamcityConnector).TriggerTeamcityBuildConfiguration(conf,
                                                   build,
                                                   branch,
                                                   comment,
                                                   tags,
                                                   arguments,
                                                   "",
                                                   false)

        member this.TriggerTeamcityBuildConfiguration(conf:ITeamcityConfiguration,
                                                      build:TCBuildConfigurationType,
                                                      branch:string,
                                                      comment:string,
                                                      tags:System.Collections.Generic.IList<string>,
                                                      arguments : System.Collections.Generic.Dictionary<string, string>,
                                                      agentString:string,
                                                      attop:bool) =
            let url = "/httpAuth/app/rest/buildQueue"
            let payload = getPayloadWithParametersXml(branch, build.Id, comment, toMap arguments, agentString, attop)
            let buildreply = httpconnector.HttpPutFileContent(conf, url, payload, "build")
            if tags <> null && tags.Count > 0 then
                Thread.Sleep(3000)
                let data = TriggerBuildResponse.Parse(buildreply)
                // apply tags
                let url = sprintf "/httpAuth/app/rest/builds/id:%i/tags" data.Id
                let payload = getTagPayload(tags)
                httpconnector.HttpPutFileContent(conf, url, payload, "build") |> ignore

        member this.GetLog(conf:ITeamcityConfiguration, id:int) =
            let url = "/downloadBuildLog.html?buildId=" + id.ToString()
            httpconnector.HttpRequest(conf, url, RestSharp.Method.GET).Content

        member this.Authenticate(conf:ITeamcityConfiguration) =
            let url = "/app/rest/vcs-roots"
            let answerData = httpconnector.HttpRequest(conf, url, RestSharp.Method.GET)
            if answerData.StatusCode <> Net.HttpStatusCode.OK then
                answerData.Content
            else
                ""

        member this.DownloadArtifact(conf:ITeamcityConfiguration, build:TcBuild, artifactPath:string, outFile:string, useDsk:bool) =
            let url = build.Href + "/artifacts/content/" + artifactPath
            downloadConnection.DownloadArtifact(conf, url, outFile, useDsk)

        member this.DeleteBuildById(conf:ITeamcityConfiguration, id:string) =
            let buildurl = "/app/rest/builds/id:" + id
            let response = httpconnector.HttpDeleteRequest(conf, buildurl)
            response.StatusCode = HttpStatusCode.NoContent

        member this.GetBuildById(conf:ITeamcityConfiguration, id:string) =
            (this :> ITeamcityConnector).GetBuildById(conf, id, true, false, false, false, false)
        member this.GetBuildById(conf:ITeamcityConfiguration, id:string, getChanges:bool) =
            (this :> ITeamcityConnector).GetBuildById(conf, id, getChanges, false, false, false, false)
        member this.GetBuildById(conf:ITeamcityConfiguration, id:string, getChanges:bool, getTests:bool) = 
            (this :> ITeamcityConnector).GetBuildById(conf, id, getChanges, getTests, false, false, false)
        member this.GetBuildById(conf:ITeamcityConfiguration, id:string, getChanges:bool, getTests:bool, getArtifacts:bool) = 
            (this :> ITeamcityConnector).GetBuildById(conf, id, getChanges, getTests, getArtifacts, false, false)
        member this.GetBuildById(conf:ITeamcityConfiguration, id:string, getChanges:bool, getTests:bool, getArtifacts:bool, getResultProps:bool) =
            (this :> ITeamcityConnector).GetBuildById(conf, id, getChanges, getTests, getArtifacts, getResultProps ,false)
        member this.GetBuildById(conf:ITeamcityConfiguration, id:string, getChanges:bool, getTests:bool, getArtifacts:bool, getResultProps:bool, getProblems:bool) =
            let buildurl = "/app/rest/builds/id:" + id
            let fullBuildData = UniqueBuildResponse.Parse(httpconnector.HttpRequest(conf, buildurl, RestSharp.Method.GET).Content)
            let newBuild = new TcBuild()
            newBuild.BuildConfigurationId <- fullBuildData.BuildType.Id
            newBuild.BuildConfigurationName <- fullBuildData.BuildType.Name
            newBuild.Href <- fullBuildData.Href
            newBuild.BuildTypeId <- fullBuildData.BuildTypeId
            newBuild.Id <- fullBuildData.Id
            newBuild.Number <- fullBuildData.Number
            newBuild.State <- fullBuildData.State
            newBuild.Status <- fullBuildData.Status
            newBuild.ProblemOccurrencesCount <- try fullBuildData.ProblemOccurrences.Count with | _ -> 0
            newBuild.ProblemOccurrencesHref <- try fullBuildData.ProblemOccurrences.Href with | _ -> ""
            newBuild.WebUrl <- fullBuildData.WebUrl
            newBuild.Branch <- fullBuildData.BranchName
            newBuild.QueuedTime <- ParseDate(fullBuildData.QueuedDate)
            newBuild.StartTime <- ParseDate(fullBuildData.StartDate)
            newBuild.EndTime <- ParseDate(fullBuildData.FinishDate)
            newBuild.Comment <- try fullBuildData.Comment.Text with | _ -> ""
            newBuild.AgentId <- try string fullBuildData.Agent.Id with | _ -> ""
            newBuild.AgentName <- try fullBuildData.Agent.Name with | _ -> ""

            newBuild.TriggerUser <- try fullBuildData.Triggered.User.Name with | ex -> ""
            newBuild.TriggerType <- fullBuildData.Triggered.Type
            if fullBuildData.Triggered.Type.ToLower() = "snapshotdependency" then
                newBuild.TriggerBuildTypeId <- try fullBuildData.Triggered.Build.BuildTypeId with | ex -> ""
                newBuild.TriggerBuildId <- try (string fullBuildData.Triggered.Build.Id) with | ex -> ""

            try
                for prop in fullBuildData.Properties.Property do
                    let propToBuild = BuildProperty()
                    propToBuild.Name <- prop.Name
                    propToBuild.Inherited <- prop.Inherited
                    propToBuild.Value <- prop.Value
                    newBuild.Properties.Add(propToBuild)

                if getResultProps then
                    GetResultingProps(newBuild,conf)
            with
            | _ -> ()

            if getArtifacts then
                let restponseArtifacts = ArtifactsPathResponse.Parse(httpconnector.HttpRequest(conf, fullBuildData.Artifacts.Href, RestSharp.Method.GET).Content)
                if restponseArtifacts.Count <> 0 then
                    for artifactElem in restponseArtifacts.File do
                        let artifcat = new Artifact()
                        artifcat.FileName <- artifactElem.Name
                        newBuild.Artifacts.Add(artifcat)

            let mutable changeLog = ""
            if getChanges then
                try
                    let buildurlchanges = sprintf "/app/rest/changes?locator=build:(id:%s)" id
                    let changesData = Changes.Parse(httpconnector.HttpRequest(conf, buildurlchanges, RestSharp.Method.GET).Content)
          
                    if changesData.Count <> 0 then
                        for change in changesData.Change do
                            let changedata = Change()
                            changedata.Date <- change.Date
                            changedata.Href <- change.Href
                            changedata.Id <- sprintf "%i" change.Id
                            changedata.UserName <- change.Username
                            changedata.Version <- change.Version
                            changedata.WebUrl <- change.WebUrl
                            
                            let change = ChangeUnique.Parse(httpconnector.HttpRequest(conf, change.Href, RestSharp.Method.GET).Content)
                            changedata.Comment <- change.Comment
                            newBuild.ChangesData.Add(changedata)
                            changeLog <- changeLog + change.Username + " : " + change.Comment + "\r\n"
                with
                | ex -> ()
            newBuild.Changes <- changeLog

            if getTests then
                GetTests(newBuild, conf)

            if getProblems then 
                GetProblems(newBuild,conf)
            newBuild

        member this.GetBuildsBranch(conf:ITeamcityConfiguration,
                                    buildConf:string,
                                    nmbBuild:int,
                                    branch:string,
                                    skipChanges:bool) =
            (this :> ITeamcityConnector).GetBuildsBranch(conf,
                                                buildConf,
                                                nmbBuild,
                                                branch,
                                                skipChanges,
                                                false,
                                                false,
                                                false,
                                                false)

        member this.GetBuildsBranch(conf:ITeamcityConfiguration,
                                    buildConf:string,
                                    nmbBuild:int,
                                    branch:string,
                                    skipChanges:bool,
                                    includeArtifacts:bool) =
            (this :> ITeamcityConnector).GetBuildsBranch(conf,
                                                buildConf,
                                                nmbBuild,
                                                branch,
                                                skipChanges,
                                                includeArtifacts,
                                                false,
                                                false,
                                                false) 

        member this.GetBuildsBranch(conf:ITeamcityConfiguration,
                                    buildConf:string,
                                    nmbBuild:int,
                                    branch:string,
                                    skipChanges:bool,
                                    includeArtifacts:bool,
                                    getResultProps:bool) =
            (this :> ITeamcityConnector).GetBuildsBranch(conf,
                                                buildConf,
                                                nmbBuild,
                                                branch,
                                                skipChanges,
                                                includeArtifacts,
                                                getResultProps,
                                                false,
                                                false) 

        member this.GetBuildsBranch(conf:ITeamcityConfiguration,
                                                buildConf:string,
                                                nmbBuild:int,
                                                branch:string,
                                                skipChanges:bool,
                                                includeArtifacts:bool,
                                                getResultProps:bool,
                                                getTests:bool) =
           (this :> ITeamcityConnector).GetBuildsBranch(conf,
                                                 buildConf,
                                                 nmbBuild,
                                                 branch,
                                                 skipChanges,
                                                 includeArtifacts,
                                                 getResultProps,
                                                 getTests,
                                                 false)

        member this.GetBuildsBranch(conf:ITeamcityConfiguration,
                                    buildConf:string,
                                    nmbBuild:int,
                                    branch:string,
                                    skipChanges:bool,
                                    includeArtifacts:bool,
                                    getResultProps:bool,
                                    getTests:bool,
                                    getProblems:bool) =
            let builds = System.Collections.Generic.List<TcBuild>()
            try
                let getBranchLocator() = 
                    if branch = "" then
                        ""
                    else
                        ",branch:" + branch

                let lookupLimitLocator =
                    if nmbBuild = -1 then
                        ""
                    else
                        "lookupLimit:" + nmbBuild.ToString() + ","

                let buildurl = "/app/rest/builds/" + "?locator=" + lookupLimitLocator + "running:any," + "buildType:" + buildConf + getBranchLocator()
                let data = BuildResponse.Parse(httpconnector.HttpRequest(conf, buildurl, RestSharp.Method.GET).Content)

                if data.Count > 0 then
                    for build in data.Build do
                        let fullBuildData = UniqueBuildResponse.Parse(httpconnector.HttpRequest(conf, build.Href, RestSharp.Method.GET).Content)
                        let newBuild = new TcBuild()
                        newBuild.Href <- fullBuildData.Href
                        newBuild.BuildTypeId <- build.BuildTypeId
                        newBuild.Id <- fullBuildData.Id
                        newBuild.Number <- build.Number.String.Value
                        newBuild.State <- fullBuildData.State
                        newBuild.Status <- fullBuildData.Status
                        newBuild.StatusText <- fullBuildData.StatusText
                        newBuild.WebUrl <- fullBuildData.WebUrl
                        newBuild.Branch <- branch
                        newBuild.BuildConfigurationId <- fullBuildData.BuildType.Id
                        newBuild.BuildConfigurationName <- fullBuildData.BuildType.Name
                        newBuild.ProblemOccurrencesCount <- try fullBuildData.ProblemOccurrences.Count with | _ -> 0
                        newBuild.ProblemOccurrencesHref <- try fullBuildData.ProblemOccurrences.Href with | _ -> ""
                        newBuild.QueuedTime <- ParseDate(fullBuildData.QueuedDate)
                        newBuild.StartTime <- ParseDate(fullBuildData.StartDate)
                        newBuild.EndTime <- ParseDate(fullBuildData.FinishDate)
                        newBuild.Comment <- try fullBuildData.Comment.Text with | _ -> ""
                        newBuild.AgentId <- try string fullBuildData.Agent.Id with | _ -> ""
                        newBuild.AgentName <- try fullBuildData.Agent.Name with | _ -> ""

                        if getTests then
                            GetTests(newBuild,conf)
                        if getProblems then
                            GetProblems(newBuild,conf)
                        try
                            for prop in fullBuildData.Properties.Property do
                                let propToBuild = BuildProperty()
                                propToBuild.Name <- prop.Name
                                propToBuild.Inherited <- try prop.Inherited with | ex -> false
                                propToBuild.Value <- prop.Value
                                newBuild.Properties.Add(propToBuild)

                            if getResultProps then
                                GetResultingProps(newBuild,conf)
                        with
                        | ex -> System.Diagnostics.Debug.WriteLine(ex.Message)
                                System.Diagnostics.Debug.WriteLine(ex.StackTrace)

                        if includeArtifacts then
                            let responseContent = httpconnector.HttpRequest(conf, fullBuildData.Artifacts.Href, RestSharp.Method.GET).Content
                            let restponseArtifacts = ArtifactsPathResponse.Parse(responseContent)
                            if restponseArtifacts.Count <> 0 then
                                for artifactElem in restponseArtifacts.File do
                                    let artifcat = new Artifact()
                                    artifcat.FileName <- artifactElem.Name
                                    newBuild.Artifacts.Add(artifcat)

                        if not(skipChanges) then
                            let mutable changeLog = ""
                            try
                                if fullBuildData.LastChanges.Count <> 0 then
                                    for change in fullBuildData.LastChanges.Change do
                                        let change = ChangeUnique.Parse(httpconnector.HttpRequest(conf, change.Href, RestSharp.Method.GET).Content)
                                        let changedata = Change()
                                        changedata.Date <- change.Date
                                        changedata.Href <- change.Href
                                        changedata.Id <- sprintf "%i" change.Id
                                        changedata.UserName <- change.Username
                                        changedata.Version <- change.Version
                                        changedata.WebUrl <- change.WebUrl
                                        changedata.Comment <- change.Comment
                                        changedata.Version <- change.Version
                                        newBuild.ChangesData.Add(changedata)
                                        changeLog <- changeLog + change.Username + " : " + change.Comment + "\r\n"
                            with
                            | ex -> ()
                            newBuild.Changes <- changeLog

                        //let changes = GetChanges()
                        builds.Add(newBuild)

            with
            | ex -> ()

            builds

        member this.GetBuildsBranch(conf:ITeamcityConfiguration,
                                    buildConf:TCBuildConfigurationType,
                                    nmbBuild:int,
                                    branch:string,
                                    skipChanges:bool) =
            (this :> ITeamcityConnector).GetBuildsBranch(conf, buildConf, nmbBuild, branch, skipChanges, false, false)

        member this.GetBuildsBranch(conf:ITeamcityConfiguration,
                                    buildConf:TCBuildConfigurationType,
                                    nmbBuild:int,
                                    branch:string,
                                    skipChanges:bool,
                                    getArtifacts:bool) =
            (this :> ITeamcityConnector).GetBuildsBranch(conf, buildConf, nmbBuild, branch, skipChanges, getArtifacts, false)

        member this.GetBuildsBranch(conf:ITeamcityConfiguration,
                                    buildConf:TCBuildConfigurationType,
                                    nmbBuild:int,
                                    branch:string,
                                    skipChanges:bool,
                                    getArtifacts:bool,
                                    getResultProps:bool) =
            let builds = System.Collections.Generic.List<TcBuild>()
            try
                let getBranchLocator() = 
                    if buildConf.BranchLocator <> "" then
                        buildConf.BranchLocator
                    else
                        if branch = "" then
                            ""
                        else
                            ",branch:" + branch

                let lookupLimitLocator =
                    if nmbBuild = -1 then
                        ""
                    else
                        "lookupLimit:" + nmbBuild.ToString() + ","

                let buildurl = buildConf.BuildIdRef + "?locator=" + lookupLimitLocator + "running:any" + getBranchLocator()
                let data = BuildResponse.Parse(httpconnector.HttpRequest(conf, buildurl, RestSharp.Method.GET).Content)

                if data.Count > 0 then
                    for build in data.Build do
                        let fullBuildData = UniqueBuildResponse.Parse(httpconnector.HttpRequest(conf, build.Href, RestSharp.Method.GET).Content)
                        let newBuild = new TcBuild()
                        newBuild.Artifact <- buildConf.Artifact
                        newBuild.ArtifactHref <- fullBuildData.Artifacts.Href
                        newBuild.Configuration <- buildConf.Configuration
                        newBuild.Platform <- buildConf.Platform
                        newBuild.Href <- fullBuildData.Href
                        newBuild.BuildTypeId <- build.BuildTypeId
                        newBuild.Id <- fullBuildData.Id
                        newBuild.Number <- build.Number.String.Value
                        newBuild.State <- fullBuildData.State
                        newBuild.Status <- fullBuildData.Status
                        newBuild.WebUrl <- fullBuildData.WebUrl
                        newBuild.Branch <- branch
                        newBuild.BuildConfigurationId <- fullBuildData.BuildType.Id
                        newBuild.BuildConfigurationName <- fullBuildData.BuildType.Name
                        newBuild.QueuedTime <- ParseDate(fullBuildData.QueuedDate)
                        newBuild.StartTime <- ParseDate(fullBuildData.StartDate)
                        newBuild.EndTime <- ParseDate(fullBuildData.FinishDate)
                        newBuild.Comment <- try fullBuildData.Comment.Text with | _ -> ""
                        newBuild.AgentId <- try string fullBuildData.Agent.Id with | _ -> ""
                        newBuild.AgentName <- try fullBuildData.Agent.Name with | _ -> ""

                        try
                            for prop in fullBuildData.Properties.Property do
                                let propToBuild = BuildProperty()
                                propToBuild.Name <- prop.Name
                                propToBuild.Inherited <- prop.Inherited
                                propToBuild.Value <- prop.Value
                                newBuild.Properties.Add(propToBuild)

                            if getResultProps then
                                GetResultingProps(newBuild,conf)

                        with
                        | _ -> ()

                        if getArtifacts then
                            let restponseArtifacts = ArtifactsPathResponse.Parse(httpconnector.HttpRequest(conf, fullBuildData.Artifacts.Href, RestSharp.Method.GET).Content)
                            if restponseArtifacts.Count <> 0 then
                                for artifactElem in restponseArtifacts.File do
                                    let artifcat = new Artifact()
                                    artifcat.FileName <- artifactElem.Name
                                    newBuild.Artifacts.Add(artifcat)

                        if not(skipChanges) then
                            let mutable changeLog = ""
                            try
                                if fullBuildData.LastChanges.Count <> 0 then
                                    for change in fullBuildData.LastChanges.Change do
                                        let change = ChangeUnique.Parse(httpconnector.HttpRequest(conf, change.Href, RestSharp.Method.GET).Content)
                                        let changedata = Change()
                                        changedata.Date <- change.Date
                                        changedata.Href <- change.Href
                                        changedata.Id <- sprintf "%i" change.Id
                                        changedata.UserName <- change.Username
                                        changedata.Version <- change.Version
                                        changedata.WebUrl <- change.WebUrl
                                        changedata.Comment <- change.Comment
                                        changedata.Version <- change.Version
                                        newBuild.ChangesData.Add(changedata)
                                        changeLog <- changeLog + change.Username + " : " + change.Comment + "\r\n"
                            with
                            | ex -> ()
                            newBuild.Changes <- changeLog

                        //let changes = GetChanges()
                        builds.Add(newBuild)

            with
            | ex -> ()

            builds

        member this.GetFailedBuildsFromConfiguration(conf:ITeamcityConfiguration, buildConfig:string, branch:string) =
            let buildurl = sprintf "/app/rest/builds/?locator=buildType:%s,branch:%s,status:FAILURE,count:1000" buildConfig branch
            let data = BuildSummaryResponse.Parse(httpconnector.HttpRequest(conf, buildurl, RestSharp.Method.GET).Content)
            let builds = System.Collections.Generic.List<TcBuild>()
            if data.Count > 0 then
                for build in data.Build do
                    let newBuild = new TcBuild()
                    newBuild.Href <- build.Href
                    newBuild.BuildTypeId <- build.BuildTypeId
                    newBuild.Id <- build.Id.ToString()
                    newBuild.Number <- build.Number.ToString()
                    newBuild.State <- build.State
                    newBuild.Status <- build.Status
                    newBuild.WebUrl <- build.WebUrl
                    newBuild.Branch <- build.BranchName
                    builds.Add(newBuild)

            builds

        member this.GetFailedBuildsFromProjectFaster(conf:ITeamcityConfiguration, projectName:string, branch:string) =
            let buildurlFirst = sprintf "/app/rest/buildTypes?locator=affectedProject:(id:%s)&fields=buildType(id,builds($locator(branch:%s,count:1),build))" projectName branch
            let dataFirst = QueryFailedBuilds.Parse(httpconnector.HttpRequest(conf, buildurlFirst, RestSharp.Method.GET).Content)
            let builds = System.Collections.Generic.List<TcBuild>()
            for buildtype in dataFirst.BuildType do
                for build in buildtype.Builds.Build do
                    if build.Status = "FAILURE" then
                        let newBuild = new TcBuild()
                        newBuild.Href <- build.BuildTypeId
                        newBuild.BuildTypeId <- build.BuildTypeId
                        newBuild.Id <- build.Id.ToString()
                        newBuild.Number <- build.Number.ToString()
                        newBuild.State <- build.State
                        newBuild.Status <- build.Status
                        newBuild.WebUrl <- build.WebUrl
                        newBuild.Branch <- build.BranchName
                        builds.Add(newBuild)
            builds

        member this.GetBuildsFromProjectFaster(conf:ITeamcityConfiguration, projectName:string, branch:string) =
            let buildurlFirst = sprintf "/app/rest/buildTypes?locator=affectedProject:(id:%s)&fields=buildType(id,builds($locator(branch:%s,count:1),build))" projectName branch
            let dataFirst = QueryFailedBuilds.Parse(httpconnector.HttpRequest(conf, buildurlFirst, RestSharp.Method.GET).Content)
            let builds = System.Collections.Generic.List<TcBuild>()
            for buildtype in dataFirst.BuildType do
                for build in buildtype.Builds.Build do
                    let newBuild = new TcBuild()
                    newBuild.Href <- build.BuildTypeId
                    newBuild.BuildTypeId <- build.BuildTypeId
                    newBuild.Id <- build.Id.ToString()
                    newBuild.Number <- build.Number.ToString()
                    newBuild.State <- build.State
                    newBuild.Status <- build.Status
                    newBuild.WebUrl <- build.WebUrl
                    newBuild.Branch <- build.BranchName
                    builds.Add(newBuild)
            builds

        member this.GetFailedBuildsFromProject(conf:ITeamcityConfiguration, projectName:string, branch:string) =
            let buildurlFirst = sprintf "/app/rest/builds/?locator=affectedProject:(id:%s),branch:%s,status:FAILURE,count:1000" projectName branch
            let dataFirst = BuildSummaryResponse.Parse(httpconnector.HttpRequest(conf, buildurlFirst, RestSharp.Method.GET).Content)
            let builds = System.Collections.Generic.List<TcBuild>()
            if dataFirst.Count > 0 then
                for build in dataFirst.Build do
                    let buildurl = sprintf "/app/rest/builds/?locator=buildType:%s,branch:%s,count:1000" build.BuildTypeId branch
                    let data = BuildSummaryResponse.Parse(httpconnector.HttpRequest(conf, buildurl, RestSharp.Method.GET).Content)
                    if data.Count > 0 && data.Build.[0].Status = "FAILURE" then
                        let newBuild = new TcBuild()
                        newBuild.Href <- build.Href
                        newBuild.BuildTypeId <- build.BuildTypeId
                        newBuild.Id <- build.Id.ToString()
                        newBuild.Number <- build.Number.ToString()
                        newBuild.State <- build.State
                        newBuild.Status <- build.Status
                        newBuild.WebUrl <- build.WebUrl
                        newBuild.Branch <- build.BranchName

                        builds.Add(newBuild)


            builds

        member this.GetBuildsFromBuildCondiguration(conf:ITeamcityConfiguration,
                                                    buildConf:string,
                                                    branch:string) =
                (this :> ITeamcityConnector).GetBuildsFromBuildCondiguration(conf, buildConf, branch, true, false, 1000)

        member this.GetBuildsFromBuildCondiguration(conf:ITeamcityConfiguration,
                                                    buildConf:string,
                                                    branch:string,
                                                    getdetailedChangeLog:bool) =
                (this :> ITeamcityConnector).GetBuildsFromBuildCondiguration(conf, buildConf, branch, getdetailedChangeLog, false, 1000)
                                                

        member this.GetBuildsFromBuildCondiguration(conf:ITeamcityConfiguration,
                                                    buildConf:string,
                                                    branch:string,
                                                    getdetailedChangeLog:bool,
                                                    getTests:bool) =
                (this :> ITeamcityConnector).GetBuildsFromBuildCondiguration(conf, buildConf, branch, getdetailedChangeLog, getTests, 1000)

        member this.GetBuildsFromBuildCondiguration(conf:ITeamcityConfiguration,
                                                    buildConf:string,
                                                    branch:string,
                                                    getdetailedChangeLog:bool,
                                                    getTests:bool,
                                                    lookupLimitLocator:int) =
                (this :> ITeamcityConnector).GetBuildsFromBuildCondiguration(conf, buildConf, branch, getdetailedChangeLog, getTests, lookupLimitLocator, false)

        member this.GetBuildsFromBuildCondiguration(conf:ITeamcityConfiguration,
                                                    buildConf:string,
                                                    branch:string,
                                                    getdetailedChangeLog:bool,
                                                    getTests:bool,
                                                    lookupLimitLocator:int,
                                                    getResultProps:bool) =

            let lookupLimitLocator =
                sprintf "lookupLimit:%i," lookupLimitLocator

            let builds = System.Collections.Generic.List<TcBuild>()
            try
                let getBranchLocator() = 
                    if branch = "" then
                        ""
                    else
                        ",branch:" + branch

                let buildurl = "/app/rest/builds/" + "?locator=" + lookupLimitLocator + "buildType:" + buildConf + getBranchLocator()
                let data = BuildResponse.Parse(httpconnector.HttpRequest(conf, buildurl, RestSharp.Method.GET).Content)

                if data.Count > 0 then
                    for build in data.Build do
                        let fullBuildData = UniqueBuildResponse.Parse(httpconnector.HttpRequest(conf, build.Href, RestSharp.Method.GET).Content)
                        let newBuild = new TcBuild()
                        newBuild.Href <- fullBuildData.Href
                        newBuild.BuildTypeId <- build.BuildTypeId
                        newBuild.Id <- fullBuildData.Id
                        newBuild.Number <- build.Number.String.Value
                        newBuild.State <- fullBuildData.State
                        newBuild.Status <- fullBuildData.Status
                        newBuild.WebUrl <- fullBuildData.WebUrl
                        newBuild.Branch <- branch
                        newBuild.BuildConfigurationId <- fullBuildData.BuildType.Id
                        newBuild.BuildConfigurationName <- fullBuildData.BuildType.Name
                        newBuild.QueuedTime <- ParseDate(fullBuildData.QueuedDate)
                        newBuild.StartTime <- ParseDate(fullBuildData.StartDate)
                        newBuild.EndTime <- ParseDate(fullBuildData.FinishDate)
                        newBuild.Comment <- try fullBuildData.Comment.Text with | _ -> ""
                        newBuild.AgentId <- try string fullBuildData.Agent.Id with | _ -> ""
                        newBuild.AgentName <- try fullBuildData.Agent.Name with | _ -> ""

                        try
                            for prop in fullBuildData.Properties.Property do
                                let propToBuild = BuildProperty()
                                propToBuild.Name <- prop.Name
                                propToBuild.Inherited <- prop.Inherited
                                propToBuild.Value <- prop.Value
                                newBuild.Properties.Add(propToBuild)

                            if getResultProps then
                                GetResultingProps(newBuild,conf)

                        with
                        | _ -> ()

                        if getTests then
                           GetTests(newBuild,conf)
                        if getdetailedChangeLog then
                            let mutable changeLog = ""
                            let replyChangeData = Changes.Parse(httpconnector.HttpRequest(conf, fullBuildData.Changes.Href, RestSharp.Method.GET).Content)
                            try
                                if replyChangeData.Count > 0 then
                                    for change in replyChangeData.Change do
                                        let replyChangeDataUnique = ChangeUnique.Parse(httpconnector.HttpRequest(conf, change.Href, RestSharp.Method.GET).Content)
                                        let changedata = Change()
                                        changedata.Date <- replyChangeDataUnique.Date
                                        changedata.Href <- replyChangeDataUnique.Href
                                        changedata.Id <- sprintf "%i" replyChangeDataUnique.Id
                                        changedata.UserName <- replyChangeDataUnique.Username
                                        changedata.Version <- replyChangeDataUnique.Version
                                        changedata.WebUrl <- replyChangeDataUnique.WebUrl
                                        changedata.Comment <- replyChangeDataUnique.Comment
                                        changedata.Version <- replyChangeDataUnique.Version
                                        newBuild.ChangesData.Add(changedata)
                                        changeLog <- changeLog + replyChangeDataUnique.Username + " : " + replyChangeDataUnique.Comment + "\r\n"
                            with ex -> ()
                            newBuild.Changes <- changeLog
                        builds.Add(newBuild)
            with
            | ex -> ()

            builds


        member this.GetLastRunningBuildForConfig(builds : System.Collections.Generic.List<TcBuild>, platform : string, config : string) = 
            let mutable lastbuild : TcBuild = null
            for build in builds do
                if build.Configuration.Equals(config) && build.Platform.Equals(platform) then
                    if lastbuild = null || build.Number > lastbuild.Number then
                        lastbuild <- build

            lastbuild

        member this.GetAllProjects(conf:ITeamcityConfiguration, configuration:string) =
            
            let url = 
                if configuration = "" then
                    "/app/rest/projects/id:_Root"
                else
                    "/app/rest/projects/id:" + configuration

            GetProjectsFromReply(httpconnector.HttpRequest(conf, url, RestSharp.Method.GET).Content, conf)

        member this.GetAllUsers(conf:ITeamcityConfiguration) =
            try
            let url = "/app/rest/users"
            let reply = httpconnector.HttpRequest(conf, url, RestSharp.Method.GET).Content
            let users = new System.Collections.Generic.List<TcUser>()
            let dataParsed = AllUsersResponse.Parse(reply)
            if dataParsed.Count > 0 then
                for user in dataParsed.User do
                    let newUser = new TcUser()
                    newUser.Id <- user.Id.ToString()
                    newUser.Name <- user.Name
                    newUser.Href <- user.Href
                    newUser.UserName <- user.Username
                    let replyDetails = httpconnector.HttpRequest(conf, user.Href, RestSharp.Method.GET).Content
                    let dataParsedDetails = UserRespose.Parse(replyDetails)
                    newUser.Email <- dataParsedDetails.Email
                    users.Add(newUser)
            users
            with _ ->  System.Collections.Generic.List<TcUser>()
            
         member this.GetUserByDisplayName(conf:ITeamcityConfiguration,name:string) =
             try
             let encodedName= System.Web.HttpUtility.HtmlEncode(name)
             let url = "/app/rest/users/name:" + encodedName
             let reply = httpconnector.HttpRequest(conf, url, RestSharp.Method.GET).Content
             let dataParsed = UserRespose.Parse(reply)
             let newUser = new TcUser()
             newUser.Id <- try dataParsed.Id.ToString() with | _ -> ""
             newUser.Name <- try dataParsed.Name with | _ -> ""
             newUser.Href <- try dataParsed.Href with | _ -> ""
             newUser.UserName <- try dataParsed.Username with | _ -> ""
             newUser.Email <- try dataParsed.Email with | _ -> ""
             newUser
             with _ -> TcUser()

        member this.GetUserByEmail(conf:ITeamcityConfiguration,email:string) =
             try
             let encodedemail= System.Web.HttpUtility.HtmlEncode(email)
             let url = "/app/rest/users/email:" + encodedemail
             let reply = httpconnector.HttpRequest(conf, url, RestSharp.Method.GET).Content
             let dataParsed = UserRespose.Parse(reply)
             let newUser = new TcUser()
             newUser.Id <- try dataParsed.Id.ToString() with | _ -> ""
             newUser.Name <- try dataParsed.Name with | _ -> ""
             newUser.Href <- try dataParsed.Href with | _ -> ""
             newUser.UserName <- try dataParsed.Username with | _ -> ""
             newUser.Email <- try dataParsed.Email with | _ -> ""
             newUser
             with _ -> new TcUser()

        member this.GetUserById(conf:ITeamcityConfiguration,id:string) =
            try
            let url = "/app/rest/users/id:"+id
            let reply = httpconnector.HttpRequest(conf, url, RestSharp.Method.GET).Content
            let dataParsed = UserRespose.Parse(reply)
            let newUser = new TcUser()
            newUser.Id <- try dataParsed.Id.ToString() with | _ -> ""
            newUser.Name <- try dataParsed.Name with | _ -> ""
            newUser.Href <- try dataParsed.Href with | _ -> ""
            newUser.UserName <- try dataParsed.Username with | _ -> ""
            newUser.Email <- try dataParsed.Email with | _ -> ""
            newUser
            with _ -> new TcUser()
        
        member this.GetUserByUserName(conf:ITeamcityConfiguration,username:string) =
            try
            let url = "/app/rest/users/username:"+username
            let reply = httpconnector.HttpRequest(conf, url, RestSharp.Method.GET).Content
            let dataParsed = UserRespose.Parse(reply)
            let newUser = new TcUser()
            newUser.Id <- try dataParsed.Id.ToString() with | _ -> ""
            newUser.Name <- try dataParsed.Name with | _ -> ""
            newUser.Href <- try dataParsed.Href with | _ -> ""
            newUser.UserName <- try dataParsed.Username with | _ -> ""
            newUser.Email <- try dataParsed.Email with | _ -> ""
            newUser
            with _ -> TcUser()
