namespace TeamcityRestConnector

open System
open System.Threading
open System.Net
open TeamcityRestTypes
open System.Globalization
open System.IO
open RestSharp
open RestSharp.Authenticators

type MuteResolution = Automatic | Manual | AtTime

type ITeamcityConnector = 
  abstract member GetAllProjects : ConnectionConfiguration:ITeamcityConfiguration * buildConfig:string -> TcProject

  abstract member GetVcsRoots : ConnectionConfiguration:ITeamcityConfiguration * count:int * projectId:string * includeDetails:bool -> System.Collections.Generic.List<VcRoot>
  abstract member GetVcsRootsSimple : ConnectionConfiguration:ITeamcityConfiguration * count:int * projectId:string -> System.Collections.Generic.List<VcRoot>
  abstract member SetVcsRootsProperty : ConnectionConfiguration:ITeamcityConfiguration * id:string * propName:string * propValue:string -> bool
  
  abstract member GetAllUsers : ConnectionConfiguration:ITeamcityConfiguration -> System.Collections.Generic.List<TcUser>
  abstract member GetUserByDisplayName : ConnectionConfiguration:ITeamcityConfiguration * name:string -> TcUser
  abstract member GetUserByEmail : ConnectionConfiguration:ITeamcityConfiguration * email:string -> TcUser
  abstract member GetUserById : ConnectionConfiguration:ITeamcityConfiguration * id:string -> TcUser
  abstract member GetUserByUserName : ConnectionConfiguration:ITeamcityConfiguration * username:string -> TcUser
  abstract member GetUser : ConnectionConfiguration:ITeamcityConfiguration -> TcUser
  abstract member UpdateUserLogin : ConnectionConfiguration:ITeamcityConfiguration * user:TcUser * newUserName:string  -> RestResponse

  abstract member GetTestDetails: test:TcTest * conf:ITeamcityConfiguration -> unit           
  abstract member GetTestDetailsForBuild: tcBuild:TcBuild * conf:ITeamcityConfiguration * all:bool -> unit
  abstract member GetProblemsForBuild: tcBuild:TcBuild * conf:ITeamcityConfiguration -> unit
  abstract member GetResultingProps: tcBuild:TcBuild * conf:ITeamcityConfiguration -> unit

  abstract member DeleteBuildById : ConnectionConfiguration:ITeamcityConfiguration * id:string -> bool
  abstract member GetBuildById : ConnectionConfiguration:ITeamcityConfiguration * id:string -> TcBuild
  abstract member GetBuildById : ConnectionConfiguration:ITeamcityConfiguration * id:string * getAllChanges:bool -> TcBuild
  abstract member GetBuildById : ConnectionConfiguration:ITeamcityConfiguration * id:string * getAllChanges:bool * getTests:bool -> TcBuild
  abstract member GetBuildById : ConnectionConfiguration:ITeamcityConfiguration * id:string * getAllChanges:bool * getTests:bool * getArtifcats:bool -> TcBuild
  abstract member GetBuildById : ConnectionConfiguration:ITeamcityConfiguration * id:string * getAllChanges:bool * getTests:bool * getArtifcats:bool * getResultingProps:bool -> TcBuild
  abstract member GetBuildById : ConnectionConfiguration:ITeamcityConfiguration * id:string * getAllChanges:bool * getTests:bool * getArtifcats:bool * getResultingProps:bool * getProblems:bool-> TcBuild
  abstract member GetTestsForBuild : ConnectionConfiguration:ITeamcityConfiguration * build:TcBuild -> unit

  abstract member GetTest : conf:ITeamcityConfiguration * testId:string -> TcTest
  abstract member GetLatestObservedTest : conf:ITeamcityConfiguration * testId:string -> TcTest
  
  
  abstract member GetCanceledBuilds : ConnectionConfiguration:ITeamcityConfiguration * buildConf:string * branch:string -> System.Collections.Generic.List<TcBuild>

  abstract member GetBuildsFromBuildConfiguration : ConnectionConfiguration:ITeamcityConfiguration * buildConf:string * branch:string -> System.Collections.Generic.List<TcBuild>
  abstract member GetBuildsFromBuildConfiguration : ConnectionConfiguration:ITeamcityConfiguration * buildConf:string * branch:string * getTests:bool * lookupLimit:int * getProps:bool * getResultingProps:bool * getartifacts:bool * getProblems:bool  -> System.Collections.Generic.List<TcBuild>
  abstract member GetBuildsFromBuildConfiguration : ConnectionConfiguration:ITeamcityConfiguration * buildConf:string * branch:string * getTests:bool * lookupLimit:int * getProps:bool * getResultingProps:bool * getartifacts:bool * getProblems:bool * ?fromDate:DateTime * ?untilDate:DateTime -> System.Collections.Generic.List<TcBuild>
 
  abstract member GetBuildInfoFromBuildConfiguration : conf:ITeamcityConfiguration * buildConf:string * branch:string -> System.Collections.Generic.List<TcBuild>
  abstract member GetBuildInfoFromBuildConfiguration : conf:ITeamcityConfiguration * buildConf:string * branch:string * regxForResultProps:string * lookupLimitLocator:int -> System.Collections.Generic.List<TcBuild>
  abstract member GetBuildInfoFromBuildConfiguration : conf:ITeamcityConfiguration * buildConf:string * branch:string * regxForResultProps:string * lookupLimitLocator:int * ?fromDate:DateTime * ?untilDate:DateTime -> System.Collections.Generic.List<TcBuild>
  
  abstract member GetFailedBuildsFromProject : ConnectionConfiguration:ITeamcityConfiguration * ProjectName:string * branch:string -> System.Collections.Generic.List<TcBuild>
  abstract member GetLastBuildsFromProject : ConnectionConfiguration:ITeamcityConfiguration * ProjectName:string * branch:string * isDefault:bool -> System.Collections.Generic.List<TcBuild>
  abstract member GetLastBuildFromBuildConfiguration : ConnectionConfiguration:ITeamcityConfiguration * ProjectName:string * branch:string -> System.Collections.Generic.List<TcBuild>
  
  abstract member GetFailedBuildsFromConfiguration : ConnectionConfiguration:ITeamcityConfiguration * buildConf:string * branch:string -> System.Collections.Generic.List<TcBuild>
  
  abstract member DownloadArtifact : ConnectionConfiguration:ITeamcityConfiguration * build:TcBuild * artifactpath:string * outFile:string * useDisk:bool -> unit
  abstract member Authenticate : ConnectionConfiguration:ITeamcityConfiguration -> string
  abstract member GetLog : ConnectionConfiguration:ITeamcityConfiguration * id:int -> string
  abstract member GetPendingChangesForBuildType : ConnectionConfiguration:ITeamcityConfiguration * buildTypeId:string * branch:string * limitForChanges:int -> System.Collections.Generic.List<Change>
  abstract member TriggerTeamcityBuild : ConnectionConfiguration:ITeamcityConfiguration * build:TcBuild * branch:string -> unit
  abstract member TriggerTeamcityBuild : ConnectionConfiguration:ITeamcityConfiguration * build:string * branch:string * comment:string * parameters:System.Collections.Generic.Dictionary<string, string> -> string * string
  abstract member TriggerTeamcityBuild : ConnectionConfiguration:ITeamcityConfiguration * build:string * branch:string * comment:string * parameters:System.Collections.Generic.Dictionary<string, string> * agentid:string * attop:bool -> string * string
  abstract member TriggerTeamcityBuild : ConnectionConfiguration:ITeamcityConfiguration * build:string * branch:string * comment:string * parameters:System.Collections.Generic.Dictionary<string, string> * agentid:string * attop:bool * revision:string -> string * string
  abstract member TriggerTeamcityBuildConfiguration : ConnectionConfiguration:ITeamcityConfiguration * build:TCBuildConfigurationType * branch:string * comment:string * tags:System.Collections.Generic.IList<string> * arguments:System.Collections.Generic.Dictionary<string, string> -> unit
  abstract member TriggerTeamcityBuildConfiguration : ConnectionConfiguration:ITeamcityConfiguration * build:TCBuildConfigurationType * branch:string * comment:string * tags:System.Collections.Generic.IList<string> * arguments:System.Collections.Generic.Dictionary<string, string> * agentid:string * attop:bool -> unit  
  abstract member GetQueuedBuilds : ConnectionConfiguration:ITeamcityConfiguration -> System.Collections.Generic.List<QueueBuild>
  abstract member GetQueuedBuild : ConnectionConfiguration:ITeamcityConfiguration * urlRef:string * branch:string -> QueueBuild
  abstract member GetQueuedAndRunningBuildsByBranch : ConnectionConfiguration:ITeamcityConfiguration * branch:string -> System.Collections.Generic.List<QueueBuild>
  abstract member GetRunningBuildsByBranch : ConnectionConfiguration:ITeamcityConfiguration * branch:string -> System.Collections.Generic.List<QueueBuild>
  abstract member GetRunningBuilds : ConnectionConfiguration:ITeamcityConfiguration -> System.Collections.Generic.List<QueueBuild>  
  abstract member GetQueuedAndRunningBuildsByBranchAndConfig : ConnectionConfiguration:ITeamcityConfiguration * branch:string * buildTypeId:string -> System.Collections.Generic.List<QueueBuild>  
  abstract member TriggerCheckForChanges : ConnectionConfiguration:ITeamcityConfiguration * vcsRootId:string -> unit
  abstract member GetLastRunningBuildForConfig : builds:System.Collections.Generic.List<TcBuild> * platform:string  * config:string-> TcBuild
  abstract member CreateBuildConfiguration : ConnectionConfiguration:ITeamcityConfiguration * buildConfigurationJson:string -> HttpStatusCode
  abstract member CreateNewProject : ConnectionConfiguration:ITeamcityConfiguration * name:string * id:string * parent:string -> TcProject
  abstract member GetBuildConfiguration : ConnectionConfiguration:ITeamcityConfiguration * id:string -> string
  abstract member DeleteConfiguration : ConnectionConfiguration:ITeamcityConfiguration * id:string -> bool
  abstract member DeleteProject : ConnectionConfiguration:ITeamcityConfiguration * id:string -> bool
  abstract member CancelBuild : ConnectionConfiguration:ITeamcityConfiguration * buildUrl:string * readInToQueue:bool -> bool
  abstract member CancelBuild : ConnectionConfiguration:ITeamcityConfiguration * buildUrl:string * readInToQueue:bool * cancelingComment:string * cancelingApplication:string -> bool
  abstract member MoveBuildToTop : ConnectionConfiguration:ITeamcityConfiguration * buildid:string -> bool
  
  abstract member GetAllMutesInAffectedProject : ConnectionConfiguration:ITeamcityConfiguration * affectedProject:string * resolutionType:MuteResolution -> System.Collections.Generic.List<MuteDetails>
  abstract member MuteTest : ConnectionConfiguration:ITeamcityConfiguration * scopeId:string * reason:string * resolutionType:MuteResolution * testName:string -> bool
  abstract member UnMuteTest : ConnectionConfiguration:ITeamcityConfiguration * muteId:string -> string
  abstract member GetAgents : ConnectionConfiguration:ITeamcityConfiguration * bool -> System.Collections.Generic.List<TcAgent>
  abstract member GetAgents : ConnectionConfiguration:ITeamcityConfiguration * bool * bool * bool -> System.Collections.Generic.List<TcAgent>
  abstract member GetUnAuthorizedAgents : ConnectionConfiguration:ITeamcityConfiguration -> System.Collections.Generic.List<TcAgent>
  
  abstract member GetAllAgents : ConnectionConfiguration:ITeamcityConfiguration * bool -> System.Collections.Generic.List<TcAgent>
  abstract member DisableAgent : ConnectionConfiguration:ITeamcityConfiguration * id:string -> bool
  abstract member DisableAgent : ConnectionConfiguration:ITeamcityConfiguration * id:string * reason:string -> bool
  abstract member EnableAgent : ConnectionConfiguration:ITeamcityConfiguration * id:string -> bool
  abstract member EnableAgent : ConnectionConfiguration:ITeamcityConfiguration * id:string * reason:string -> bool
  abstract member AuthorizeAgent : ConnectionConfiguration:ITeamcityConfiguration * id:string -> bool
  abstract member AuthorizeAgent : ConnectionConfiguration:ITeamcityConfiguration * id:string * reason:string -> bool
  abstract member UnauthorizeAgent : ConnectionConfiguration:ITeamcityConfiguration * id:string -> bool
  abstract member UnauthorizeAgent : ConnectionConfiguration:ITeamcityConfiguration * id:string * reason:string -> bool

  abstract member GetBuildConfigurationsFromProject : ConnectionConfiguration:ITeamcityConfiguration * projectToCheck:string -> System.Collections.Generic.List<TCBuildConfigurationType>

type TeamcityConnector(httpconnector : IHttpTeamcityConnector) = 
    let httpconnector = httpconnector
    let mutable data = ""
    let mutable tags = ""

    let ParseDate(datestring:string) =
        let dateWithoutLocale = 
            if datestring.Contains("+") then
                datestring.Split('+').[0]
            else
                datestring
        if dateWithoutLocale <> "" then
            try DateTime.ParseExact(dateWithoutLocale, "yyyyMMddTHHmmss", CultureInfo.InvariantCulture) with | _ -> DateTime.Now
        else
            DateTime.Now

    let SingleQueuedBuildFromBuildData(dataString:string, branch:string) = 
        let data = SingleBuildResponse.Parse(dataString)
        let newqueue = new QueueBuild()
        newqueue.BuildTypeId <- data.BuildTypeId
        newqueue.Id <- sprintf "%i" data.Id
        newqueue.BranchName <- branch
        newqueue.Href <- data.Href
        try
            newqueue.BuildTypeName <- data.BuildType.Name
            newqueue.ProjectId <- data.BuildType.ProjectId
            newqueue.ProjectName <- data.BuildType.ProjectName
            newqueue.BuildTypeHref <- data.BuildType.Href
            newqueue.BuildTypeWebUrl <- data.BuildType.WebUrl
            newqueue.State <- data.State
            newqueue.WebUrl <- data.WebUrl
            if dataString.Contains("\"waitReason\":") then
                newqueue.WaitReason <- data.WaitReason
            else
                newqueue.WaitReason <- ""

            if dataString.Contains("\"percentageComplete\":") then
                newqueue.CompletePercentage <- data.PercentageComplete

            if dataString.Contains("\"status\":") then
                newqueue.Status <- data.Status

            if dataString.Contains("\"startEstimate\":") then
                newqueue.StartEstimate <- try DateTime.ParseExact(data.StartEstimate.Split('+').[0], "yyyyMMddTHHmmss", CultureInfo.InvariantCulture) with | _ -> DateTime.Now

            newqueue.QueuedDate <- try DateTime.ParseExact(data.QueuedDate.Split('+').[0], "yyyyMMddTHHmmss", CultureInfo.InvariantCulture) with | _ -> DateTime.Now

            if dataString.Contains("\"comment\":") then
                try
                    let comment = TcComment()
                    comment.TimeStamp <- try DateTime.ParseExact(data.Comment.Timestamp.Split('+').[0], "yyyyMMddTHHmmss", CultureInfo.InvariantCulture) with | _ -> DateTime.Now
                    comment.Text <- data.Comment.Text
                    newqueue.Comment <- comment
                with
                | _ -> ()
            if dataString.Contains("\"agent\":") then
                try
                    let agent = TcAgent()
                    agent.Name <- data.Agent.Name
                    agent.Id <- data.Agent.Id
                    agent.Href <- data.Agent.Href
                    newqueue.RunAgent <- agent
                with
                | _ -> ()
        with
        | ex -> ()
        newqueue

    let QueuedBuildFromBuildData(data:QueuedBuildResponse.Build, branch:string) = 
        let newqueue = new QueueBuild()
        newqueue.BuildTypeId <- data.BuildTypeId
        newqueue.Id <- sprintf "%i" data.Id
        if branch = "" then
            if data.BranchName.String.IsSome then
                newqueue.BranchName <- data.BranchName.String.Value
        else
            newqueue.BranchName <- branch

        newqueue.Href <- data.Href
        try
            if data.RunningInfo.IsSome then
                newqueue.CompletePercentage <- data.RunningInfo.Value.PercentageComplete
                newqueue.ProbablyHanging <- data.RunningInfo.Value.ProbablyHanging
                newqueue.Outdated <- data.RunningInfo.Value.Outdated
                newqueue.CurrentStageText <- data.RunningInfo.Value.CurrentStageText.ToString()
                newqueue.ElapsedSeconds <- data.RunningInfo.Value.ElapsedSeconds
                newqueue.EstimatedTotalSeconds <- data.RunningInfo.Value.EstimatedTotalSeconds

            newqueue.BuildTypeName <- data.BuildType.Name
            newqueue.ProjectId <- data.BuildType.ProjectId
            newqueue.ProjectName <- data.BuildType.ProjectName
            newqueue.BuildTypeHref <- data.BuildType.Href
            newqueue.BuildTypeWebUrl <- data.BuildType.WebUrl
            newqueue.State <- data.State
            newqueue.WebUrl <- data.WebUrl

            if data.PercentageComplete.IsSome then
                try
                    newqueue.CompletePercentage <- data.PercentageComplete.Value
                with
                | _ -> newqueue.CompletePercentage <- 0
            if data.Number.IsSome then newqueue.Number <- data.Number.Value
            if data.WaitReason.IsSome then newqueue.WaitReason <- data.WaitReason.Value else newqueue.WaitReason <- ""
            if data.Status.IsSome then newqueue.Status <- data.Status.Value
            if data.StartEstimate.IsSome then
                newqueue.StartEstimate <- try DateTime.ParseExact(data.StartEstimate.Value.Split('+').[0], "yyyyMMddTHHmmss", CultureInfo.InvariantCulture) with | _ -> DateTime.Now
            newqueue.QueuedDate <- try DateTime.ParseExact(data.QueuedDate.Split('+').[0], "yyyyMMddTHHmmss", CultureInfo.InvariantCulture) with | _ -> DateTime.Now
            if data.StartDate.IsSome then
                newqueue.StartDate <- try DateTime.ParseExact(data.StartDate.Value.Split('+').[0], "yyyyMMddTHHmmss", CultureInfo.InvariantCulture) with | _ -> DateTime.Now

            if data.Comment.IsSome then
                let comment = TcComment()
                comment.TimeStamp <- try DateTime.ParseExact(data.Comment.Value.Timestamp.Split('+').[0], "yyyyMMddTHHmmss", CultureInfo.InvariantCulture) with | _ -> DateTime.Now
                comment.Text <- data.Comment.Value.Text
                newqueue.Comment <- comment

            if data.Agent.IsSome then 
                let agent = TcAgent()
                agent.Name <- data.Agent.Value.Name
                agent.Id <- data.Agent.Value.Id
                agent.Href <- data.Agent.Value.Href
                newqueue.RunAgent <- agent
        with
        | ex -> 
            ()
        newqueue
    
    let getMuteInfo(reply:string) =       
        let dataParsed = MuteResponse.Parse(reply)
        let mutes = new System.Collections.Generic.List<MuteDetails>()
        for mute in dataParsed.Mute do
            let muteToSave = MuteDetails()
            muteToSave.Id <- mute.Id.ToString()
            muteToSave.Href <- mute.Href
            mutes.Add(muteToSave)

            if mute.Target.Tests.IsSome then
                for test in mute.Target.Tests.Value.Test do
                    let testToSave = TcTest()
                    testToSave.Name <- test.Name
                    testToSave.Id <- test.Id.ToString()
                    testToSave.Href <- test.Href
                    muteToSave.Tests.Add(testToSave)

            if mute.Target.Problems.IsSome then
                for test in mute.Target.Problems.Value.Problem do
                    let testToSave = TcTest()
                    testToSave.Name <- test.Type
                    testToSave.Id <- test.Id.ToString()
                    testToSave.Href <- test.Href
                    muteToSave.Tests.Add(testToSave)
        mutes


    let GetAgentsInfo(reply:string, details:bool, conf:ITeamcityConfiguration) =       
        let dataParsed = AgentsResponse.Parse(reply)
        let agents = new System.Collections.Generic.List<TcAgent>()
        for agent in dataParsed.Agent do
            let agentNew = TcAgent()
            agentNew.Name <- agent.Name
            agentNew.Id <- agent.Id
            agentNew.Ip <- agent.Ip.Value
            agentNew.WebUrl <- agent.WebUrl
            if agent.Enabled.IsSome then
                agentNew.Enabled <- agent.Enabled.Value
            if agent.Authorized.IsSome then
                agentNew.Authorized <- agent.Authorized.Value
            if agent.Connected.IsSome then
                agentNew.Connected <- agent.Connected.Value

            agentNew.Href <- agent.Href
            let pool = TcAgentPool()
            pool.Id <- agent.Pool.Value.Id
            pool.Href <- agent.Pool.Value.Href
            pool.Name  <- agent.Pool.Value.Name
            agentNew.AgentPool <- pool
            if details then
                let replyDetails = httpconnector.HttpRequest(conf, agent.Href, RestSharp.Method.Get).Content
                let dataParsedDetails = AgentDetails.Parse(replyDetails)
                let authorizedInfoData = dataParsedDetails.AuthorizedInfo.JsonValue.ToString()
                let authorizedStatusInfo = new StatusInfo()
                authorizedStatusInfo.Status <- dataParsedDetails.AuthorizedInfo.Status
                if authorizedInfoData.Contains("comment") then
                    let tcComment = new TcComment()                        
                    if authorizedInfoData.Contains("user") then
                        tcComment.User <- dataParsedDetails.AuthorizedInfo.Comment.User.Name
                        tcComment.UserName <- dataParsedDetails.AuthorizedInfo.Comment.User.Username
                    if authorizedInfoData.Contains("text") then
                        tcComment.Text <- dataParsedDetails.AuthorizedInfo.Comment.Text
                    if authorizedInfoData.Contains("timestamp") then
                        tcComment.TimeStamp <- try DateTime.ParseExact(dataParsedDetails.AuthorizedInfo.Comment.Timestamp.Split('+').[0], "yyyyMMddTHHmmss", CultureInfo.InvariantCulture) with | _ -> DateTime.Now
                    authorizedStatusInfo.Comment <- tcComment
                agentNew.AuthorizedInfo <- authorizedStatusInfo

                let enabledInfoData = dataParsedDetails.EnabledInfo.JsonValue.ToString()
                let enabledStatusInfo = new StatusInfo()
                enabledStatusInfo.Status <- dataParsedDetails.EnabledInfo.Status
                if enabledInfoData.Contains("comment") then
                    let tcComment = new TcComment()   
                    if enabledInfoData.Contains("user") then
                        tcComment.User <- dataParsedDetails.EnabledInfo.Comment.User.Name
                        tcComment.UserName <- dataParsedDetails.EnabledInfo.Comment.User.Username
                    if enabledInfoData.Contains("text") then
                        tcComment.Text <- dataParsedDetails.EnabledInfo.Comment.Text
                    if enabledInfoData.Contains("timestamp") then
                        tcComment.TimeStamp <- try DateTime.ParseExact(dataParsedDetails.EnabledInfo.Comment.Timestamp.Split('+').[0], "yyyyMMddTHHmmss", CultureInfo.InvariantCulture) with | _ -> DateTime.Now
                    enabledStatusInfo.Comment <- tcComment
                agentNew.EnabledInfo <- enabledStatusInfo


                for prop in dataParsedDetails.Properties.Property do
                    if prop.Value.String.IsSome then
                        agentNew.Properties.Add(prop.Name, prop.Value.String.Value)
                    else
                        agentNew.Properties.Add(prop.Name, "")

            agents.Add(agentNew)
        agents

    let GetTest(test:TcTest, conf:ITeamcityConfiguration) =
        let buildfortestdetails = test.Href
        let testMetadataStr = httpconnector.HttpRequest(conf, buildfortestdetails + "?fields=metadata", RestSharp.Method.Get).Content
        let testMetadata = TestMetaData.Parse(testMetadataStr)
        if testMetadata.Metadata.Count > 0 then
            for meta in testMetadata.Metadata.TypedValues do
                let newMeta = TcMetaData()
                newMeta.Name <- meta.Name
                newMeta.Type <- meta.Type
                newMeta.Value <- meta.Value.String.Value
                test.MetaInformation.Add(newMeta)
                        
        let testStr = httpconnector.HttpRequest(conf, buildfortestdetails, RestSharp.Method.Get).Content
        let testDetails = TestDetailsJson.Parse(testStr)
        test.FailureDetails <- testDetails.Details
        if test.Muted then
            let muteInfo = MuteDetails()
            try
                if testStr.Contains("\"mute\":") then
                    muteInfo.Href <- try testDetails.Mute.Href with | ex -> ""
                    muteInfo.Name <- try testDetails.Mute.Assignment.User.Name with | ex -> ""
                    muteInfo.UserName <- try testDetails.Mute.Assignment.User.Username with | ex -> ""
                    muteInfo.Text <- try testDetails.Mute.Assignment.Text with | ex -> ""
                    // "timestamp": "20191217T033420+0200",
                    muteInfo.TimeStamp <- try DateTime.ParseExact(testDetails.Mute.Assignment.Timestamp.Split('+').[0], "yyyyMMddTHHmmss", CultureInfo.InvariantCulture) with | _ -> DateTime.Now
                    test.MuteInformation.Add(muteInfo)
                else
                    let testMuteDetails = TestMuteDetailsJson.Parse(httpconnector.HttpRequest(conf, testDetails.Test.Href, RestSharp.Method.Get).Content)
                    if testMuteDetails.Mutes.Count > 0 then
                        let AddMute(mute:TestMuteDetailsJson.Mute) = 
                            muteInfo.Href <- try mute.Href with | ex -> ""
                            muteInfo.Name <- try mute.Assignment.User.Name with | ex -> ""
                            muteInfo.UserName <- try mute.Assignment.User.Username with | ex -> ""
                            muteInfo.Text <- try mute.Assignment.Text with | ex -> ""
                            test.MuteInformation.Add(muteInfo)

                        testMuteDetails.Mutes.Mute
                            |> Seq.iter (fun mute -> AddMute(mute))
            with
            | ex -> ()

        try
            if testDetails.JsonValue.ToString().Contains("firstFailed") then
                let firstFailure = TcTest()
                firstFailure.Href <- testDetails.FirstFailed.Href
                firstFailure.Id <- testDetails.FirstFailed.Id
                firstFailure.Status <- testDetails.FirstFailed.Status
                firstFailure.Name <- testDetails.FirstFailed.Name
                test.FirstFailure <- firstFailure
        with
        | ex -> ()

    let GetTests(build:TcBuild, conf:ITeamcityConfiguration, all:bool) =
        let buildurltests = sprintf "/app/rest/testOccurrences?locator=build:id:%s,start:0,count:100000" build.Id
        let tests = TestResponse.Parse(httpconnector.HttpRequest(conf, buildurltests, RestSharp.Method.Get).Content)
        try
            if tests.Count > 0 then
                for test in tests.TestOccurrence do
                    let newTest = new TcTest()
                    newTest.Id <- test.Id
                    newTest.Name <- test.Name
                    newTest.Duration <- if test.Duration.IsSome then test.Duration.Value else 0
                    newTest.CurrentlyInvestigated <- if test.CurrentlyInvestigated.IsSome then test.CurrentlyInvestigated.Value else false
                    newTest.CurrentlyMuted <- if test.CurrentlyMuted.IsSome then test.CurrentlyMuted.Value else false
                    newTest.Muted <- if test.Muted.IsSome then test.Muted.Value else newTest.CurrentlyMuted
                    newTest.Status <- test.Status
                    newTest.Href <- test.Href

                    if test.Status = "FAILURE" || all then
                        GetTest(newTest, conf)

                    build.Tests.Add(newTest)
        with | ex -> ()

    let GetProblems(build:TcBuild,conf:ITeamcityConfiguration)=
        let buildurlProblems= sprintf "/app/rest/problemOccurrences?locator=build:id:%s,start:0,count:1000" build.Id
        let problemOccurancesResponse = ProblemOccurancesResponse.Parse(httpconnector.HttpRequest(conf, buildurlProblems, RestSharp.Method.Get).Content)
        try
           if problemOccurancesResponse.Count > 0 then
               for problemOccurrence in problemOccurancesResponse.ProblemOccurrence do
                   let newProblem = new TcProblem()
                   let problemOccurancesDetails = ProblemOccurancesDetailsResponse.Parse(httpconnector.HttpRequest(conf, problemOccurrence.Href, RestSharp.Method.Get).Content)
                   newProblem.Id <- try problemOccurancesDetails.Problem.Id.ToString()  with | ex -> ""
                   newProblem.Href <-  try problemOccurancesDetails.Problem.Href with | ex -> ""
                   newProblem.Type <-  try problemOccurancesDetails.Problem.Type with | ex -> ""
                   newProblem.Identity <- try problemOccurancesDetails.Problem.Identity  with | ex -> ""
                   newProblem.Details <- try problemOccurancesDetails.Details with | ex -> ""
                   newProblem.AdditionalData <- try problemOccurancesDetails.AdditionalData with | ex -> ""
                   build.Problems.Add(newProblem)
        with | ex -> ()

    let GetResultingProps(build:TcBuild, conf:ITeamcityConfiguration)=
        try
            let buildurlResultingProps = build.Href + "/resulting-properties"
            let resultingProps = ResultingProperties.Parse(httpconnector.HttpRequest(conf, buildurlResultingProps, RestSharp.Method.Get).Content)
            for prop in resultingProps.Property do
                let propToBuild = BuildProperty()
                propToBuild.Name <- prop.Name
                propToBuild.Value <- prop.Value
                build.ResultingProperties.Add(propToBuild)
        with ex -> ()

    let GetAdditionBuildInformationforBuildTypes(
        baseApi:string,
        conf:ITeamcityConfiguration,
        branch:string,
        getTests:bool,
        getProps:bool,
        getResultingProps:bool,
        getProblems: bool,
        includeArtifacts: bool,
        regxForResultProps:string) =
        
        let regxForResultingProps =
            if regxForResultProps <> "" then
                sprintf ",resultingProperties($locator(name:(value:(%s),matchType:matches)),property)" regxForResultProps
            else
                ""

        let fieldsToGet =
            if getProps then
                sprintf "&fields=build(id,revisions,startDate,finishDate,queuedDate,statusText,status,href,state,webUrl,number,artifacts,changes(change(comment,version,username,date,href,webUrl)),branchName,comment,agent,buildType,properties(property)%s)" regxForResultingProps
            else
                sprintf "&fields=build(id,revisions,startDate,finishDate,queuedDate,statusText,status,href,state,webUrl,number,artifacts,changes(change(comment,version,username,date,href,webUrl)),branchName,comment,agent,buildType%s)" regxForResultingProps

        let buildurl = baseApi + fieldsToGet
        let data = BuildResponse.Parse(httpconnector.HttpRequest(conf, buildurl, RestSharp.Method.Get).Content)

        let builds = System.Collections.Generic.List<TcBuild>()
        for build in data.Build do
            let newBuild = new TcBuild()

            newBuild.Href <- build.Href
            if build.BuildType.IsSome then
                newBuild.BuildTypeId <- build.BuildType.Value.Id
                newBuild.BuildConfigurationId <- build.BuildType.Value.Id
            else
                newBuild.BuildTypeId <- build.BuildTypeId
                newBuild.BuildConfigurationId <- build.BuildTypeId

            newBuild.Id <- build.Id.ToString()
            newBuild.Number <- build.Number.String.Value
            newBuild.State <- build.State
            newBuild.Status <- build.Status
            newBuild.WebUrl <- build.WebUrl
            newBuild.StatusText <- if build.StatusText.IsSome then build.StatusText.Value else ""
            newBuild.Branch <- branch

            newBuild.Revision <-
                if build.Revisions.IsSome && build.Revisions.Value.Count > 0  then
                    build.Revisions.Value.Revision.[0].Version
                else
                    null
                    
            newBuild.BuildConfigurationName <- build.BuildType.Value.Name
            if build.QueuedDate.IsSome then
                newBuild.QueuedTime <- ParseDate(build.QueuedDate.Value)
            if build.StartDate.IsSome then
                newBuild.StartTime <- ParseDate(build.StartDate.Value)
            if build.FinishDate.IsSome then
                newBuild.EndTime <- ParseDate(build.FinishDate.Value)
            newBuild.Comment <- if build.Comment.IsSome then build.Comment.Value.Text else ""
            if build.Agent.IsSome then
                newBuild.AgentId <- string build.Agent.Value.TypeId
                newBuild.AgentName <- build.Agent.Value.Name
                
            if getProps then
                if build.Properties.IsSome then
                    for prop in build.Properties.Value.Property do
                        let propToBuild = BuildProperty()
                        propToBuild.Name <- prop.Name
                        if prop.Inherited.IsSome then
                            propToBuild.Inherited <- prop.Inherited.Value
                        propToBuild.Value <- prop.Value
                        newBuild.Properties.Add(propToBuild)
            
            if getResultingProps then
                GetResultingProps(newBuild,conf)
            else
                if build.ResultingProperties.IsSome then
                    for prop in build.ResultingProperties.Value.Property do
                        let propToBuild = BuildProperty()
                        propToBuild.Name <- prop.Name
                        propToBuild.Value <- prop.Value
                        newBuild.ResultingProperties.Add(propToBuild)                        

            if getTests then
                GetTests(newBuild, conf, false)
            if getProblems then
                GetProblems(newBuild, conf)

            if includeArtifacts then
                let responseContent = httpconnector.HttpRequest(conf, build.Artifacts.Value.Href, RestSharp.Method.Get).Content
                let restponseArtifacts = ArtifactsPathResponse.Parse(responseContent)
                if restponseArtifacts.Count <> 0 then
                    for artifactElem in restponseArtifacts.File do
                        let artifcat = new Artifact()
                        artifcat.FileName <- artifactElem.Name
                        newBuild.Artifacts.Add(artifcat)

            if build.Changes.IsSome then
                let mutable changeLog = ""
                for change in build.Changes.Value.Change do                    
                    let changedata = Change()
                    changedata.Date <- change.Date
                    changedata.Href <- change.Href
                    changedata.UserName <- change.Username
                    changedata.Version <- change.Version
                    changedata.WebUrl <- change.WebUrl
                    changedata.Comment <- change.Comment

                    newBuild.ChangesData.Add(changedata)                    

                    if newBuild.Revision = "" || newBuild.Revision = null then
                        newBuild.Revision <- change.Version
                   
                    changeLog <- changeLog +  change.Version + " : " + change.Username + " : " + change.Comment + "\r\n"

                newBuild.Changes <- changeLog
                
            builds.Add(newBuild)

        builds

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

    let changeUserPayloadXml(id:string, username:string)  = 
        sprintf """<user id="%s" username="%s"/>""" id username


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

    let getPayloadWithParametersXml(branch:string, buildid:string, comment:string, properties : Map<string,string>, agent:string, atTop:bool, revision:string)  = 
        let queueAtTop =
            if atTop then
                sprintf """<triggeringOptions queueAtTop="true"/>"""
            else
                ""
        let revision = 
            if revision <> "" then
                sprintf "<lastChanges><change locator=\"version:%s,buildType:(id:%s)\"/></lastChanges>" revision buildid
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
                                    %s%s%s
                                </build> """ (branch) queueAtTop buildid comment agentBuild revision parameters
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
                let data = ProjectResponseTags.Parse(httpconnector.HttpRequest(conf, outProject.Href, RestSharp.Method.Get).Content)
                
                if data.BuildTypes.Count > 0 then
                    for buildType in data.BuildTypes.BuildType do
                        let newConfig = new TCBuildConfigurationType()
                        newConfig.Name <- buildType.Name
                        newConfig.ParentProjectId <- buildType.ProjectId
                        newConfig.ProjectName <- buildType.ProjectName
                        newConfig.Id <- buildType.Id
                        newConfig.WebUrl <- buildType.WebUrl
                        newConfig.Href <- buildType.Href
                        let datax = BuildTypeResponse.Parse(httpconnector.HttpRequest(conf, newConfig.Href, RestSharp.Method.Get).Content)
                        try newConfig.BuildIdRef <- datax.Builds.Href with | ex -> ()
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

        member this.GetLatestObservedTest(conf:ITeamcityConfiguration, testId:string) =
            let buildurltests = sprintf "/app/rest/testOccurrences?locator=test:(id:%s),count:1" testId
            let testResponse = TestResponseWithCountOne.Parse(httpconnector.HttpRequest(conf, buildurltests, RestSharp.Method.Get).Content)
            try
                if testResponse.Count > 0 then
                    let test = testResponse.TestOccurrence.[0]
                    let newTest = new TcTest()
                    newTest.Id <- test.Id
                    newTest.Name <- test.Name
                    newTest.Duration <- if test.Duration.IsSome then test.Duration.Value else 0
                    newTest.CurrentlyInvestigated <- if test.CurrentlyInvestigated.IsSome then test.CurrentlyInvestigated.Value else false
                    newTest.CurrentlyMuted <- if test.CurrentlyMuted.IsSome then test.CurrentlyMuted.Value else false
                    newTest.Muted <- if test.Muted.IsSome then test.Muted.Value else newTest.CurrentlyMuted
                    newTest.Status <- test.Status
                    newTest.Href <- test.Href
                    newTest.PassedCnt <- try testResponse.Passed with | ex -> 0
                    newTest.MutedCnt <- try testResponse.Muted with | ex -> 0
                    newTest.FailingCnt <- try testResponse.Failing with | ex -> 0
                    newTest
                else
                    null
            with | ex -> null

        member this.GetTestDetails(test:TcTest, conf:ITeamcityConfiguration) = 
            GetTest(test, conf)

        member this.GetTestDetailsForBuild(tcBuild:TcBuild, conf:ITeamcityConfiguration, all:bool) = 
            GetTests(tcBuild, conf, all)

        member this.GetProblemsForBuild(tcBuild:TcBuild, conf:ITeamcityConfiguration) = 
            GetProblems(tcBuild, conf)

        member this.GetResultingProps(tcBuild:TcBuild, conf:ITeamcityConfiguration) = 
            GetResultingProps(tcBuild, conf)            

        member this.UpdateUserLogin(conf:ITeamcityConfiguration, user:TcUser, newUserName:string) =
            let palyload = changeUserPayloadXml(user.Id, newUserName)
            let url = sprintf "/app/rest/users/id:%s" user.Id
            httpconnector.HttpPutXmlContent(conf, url, palyload)

        member this.GetTest(conf:ITeamcityConfiguration, testId:string) =
            let url = sprintf "/app/rest/testOccurrences/%s" testId
            let content = httpconnector.HttpRequest(conf, url, RestSharp.Method.Get).Content
            let data = TestDetails.Parse(content)
            let newTest = new TcTest()
            newTest.Id <- data.Id
            newTest.Name <- data.Name
            newTest.Duration <- if content.Contains("duration") then data.Duration else 0
            newTest.CurrentlyInvestigated <- if content.Contains("currentlyInvestigated") then data.CurrentlyInvestigated else false
            newTest.CurrentlyMuted <- if content.Contains("currentlyMuted") then data.CurrentlyMuted else false
            newTest.Muted <- if content.Contains("muted") then data.Muted else newTest.CurrentlyMuted
            newTest.FailureDetails <- if content.Contains("details") then data.Details else ""            
            newTest.Status <- data.Status
            newTest.Href <- data.Href
            newTest

        member this.GetTestsForBuild(conf:ITeamcityConfiguration, build:TcBuild) =
            GetTests(build, conf, true)

        member this.UnauthorizeAgent(conf:ITeamcityConfiguration, id:string) =
            let url = sprintf "/app/rest/agents/id:%s/authorized" id
            httpconnector.HttpPutRequest(conf, url, "false")

        member this.UnauthorizeAgent(conf:ITeamcityConfiguration, id:string, reason:string) =
            let url = sprintf "/app/rest/agents/id:%s/authorizedInfo" id
            let payload = sprintf """<authorizedInfo status="false"><comment><text>%s</text></comment></authorizedInfo> """ reason
            let requestDAta = httpconnector.HttpPutXmlContent(conf, url, payload)
            requestDAta.IsSuccessful

        member this.AuthorizeAgent(conf:ITeamcityConfiguration, id:string) =
            let url = sprintf "/app/rest/agents/id:%s/authorized" id
            httpconnector.HttpPutRequest(conf, url, "true")

        member this.AuthorizeAgent(conf:ITeamcityConfiguration, id:string, reason:string) =
            let url = sprintf "/app/rest/agents/id:%s/authorizedInfo" id
            let payload = sprintf """<authorizedInfo status="true"><comment><text>%s</text></comment></authorizedInfo> """ reason
            let requestDAta = httpconnector.HttpPutXmlContent(conf, url, payload)
            requestDAta.IsSuccessful

        member this.EnableAgent(conf:ITeamcityConfiguration, id:string) =
            let url = sprintf "/app/rest/agents/id:%s/enabled" id
            httpconnector.HttpPutRequest(conf, url, "true")

        member this.MoveBuildToTop(conf:ITeamcityConfiguration, buildid:string) =
            let url = "/app/rest/buildQueue/order"
            let payload = sprintf """<builds><build id="%s"/></builds>""" buildid
            let requestDAta = httpconnector.HttpPutXmlContent(conf, url, payload)
            requestDAta.IsSuccessful

        member this.EnableAgent(conf:ITeamcityConfiguration, id:string, reason:string) =
            let url = sprintf "/app/rest/agents/id:%s/enabledInfo" id
            let payload = sprintf """<enabledInfo status="true"><comment><text>%s</text></comment></enabledInfo> """ reason
            let requestDAta = httpconnector.HttpPutXmlContent(conf, url, payload)
            requestDAta.IsSuccessful

        member this.DisableAgent(conf:ITeamcityConfiguration, id:string, reason:string) =
            let url = sprintf "/app/rest/agents/id:%s/enabledInfo" id
            let payload = sprintf """<enabledInfo status="false"><comment><text>%s</text></comment></enabledInfo> """ reason
            let requestDAta = httpconnector.HttpPutXmlContent(conf, url, payload)
            requestDAta.IsSuccessful

        member this.DisableAgent(conf:ITeamcityConfiguration, id:string) =
            let url = sprintf "/app/rest/agents/id:%s/enabled" id
            let requestDAta = httpconnector.HttpPutRequest(conf, url, "false")
            requestDAta

        member this.GetAllAgents(conf:ITeamcityConfiguration, details:bool) =
            let url = "/app/rest/agents?locator=enabled:true,connected:true"
            let reply = httpconnector.HttpRequest(conf, url, RestSharp.Method.Get).Content
            let dataParsed = AgentsResponse.Parse(reply)
            let agents = new System.Collections.Generic.List<TcAgent>()
            for agent in dataParsed.Agent do
                let agentNew = TcAgent()
                agentNew.Name <- agent.Name
                agentNew.Id <- agent.Id
                agentNew.Href <- agent.Href
                if details then
                    let replyDetails = httpconnector.HttpRequest(conf, agent.Href, RestSharp.Method.Get).Content
                    let dataParsedDetails = AgentDetails.Parse(replyDetails)
                    for prop in dataParsedDetails.Properties.Property do
                        if prop.Value.String.IsSome then
                            agentNew.Properties.Add(prop.Name, prop.Value.String.Value)
                        else
                            agentNew.Properties.Add(prop.Name, "")

                agents.Add(agentNew)
            agents

        member this.GetUnAuthorizedAgents(conf:ITeamcityConfiguration) = 
            let url = "/app/rest/agents?locator=authorized:false&fields=agent(id,name,typeId,href,webUrl,pool,ip,connected,enabled,authorized,authorizedInfo,enabledInfo,connectedInfo)"
            let reply = httpconnector.HttpRequest(conf, url, RestSharp.Method.Get).Content
            GetAgentsInfo(reply, true, conf)

        member this.GetAgents(conf:ITeamcityConfiguration, details:bool) =
            (this :> ITeamcityConnector).GetAgents(conf, details, true, true)

        member this.GetAgents(conf:ITeamcityConfiguration, details:bool, enabledOnly:bool, connectedOnly:bool) =
            let locator = sprintf "enabled:%b,connected:%b" enabledOnly connectedOnly
                    
            let url = "/app/rest/agents?" + locator + "&fields=agent(id,name,typeId,href,webUrl,pool,ip,connected,enabled,authorized,authorizedInfo,enabledInfo,connectedInfo)"                        
            let reply = httpconnector.HttpRequest(conf, url, RestSharp.Method.Get).Content
            GetAgentsInfo(reply, details, conf)

        member this.MuteTest(conf:ITeamcityConfiguration, scopeId:string, reasonTxt:string, resolution:MuteResolution, testName:string) = 
            let payload = getMutePayload(conf.Username, reasonTxt, testName, resolution, scopeId)
            let url = "/app/rest/mutes"
            httpconnector.HttpPostRequestContent(conf, url, payload).StatusCode = HttpStatusCode.OK

        member this.GetAllMutesInAffectedProject(conf:ITeamcityConfiguration, affectedProject:string, resolution:MuteResolution) = 
            let resType =
                match resolution with
                | MuteResolution.Manual -> "manually"
                | MuteResolution.Automatic -> "whenFixed"
                | MuteResolution.AtTime -> "atTime"

            let url = sprintf "/app/rest/mutes?locator=affectedProject:%s,resolution:%s,count:10000" affectedProject resType
            let reply = httpconnector.HttpRequest(conf, url, RestSharp.Method.Get).Content
            getMuteInfo(reply)

        member this.UnMuteTest(conf:ITeamcityConfiguration, muteId:string) = 
            let url = sprintf "/app/rest/mutes/id:%s" muteId
            httpconnector.HttpDeleteRequest(conf, url).Content

        member this.CancelBuild(conf:ITeamcityConfiguration, buildUrl:string, requeue:bool) = 
            let content = sprintf "<buildCancelRequest comment='Retrigger' readdIntoQueue='%b' />" requeue
            let result = httpconnector.HttpPostRequestContent(conf, buildUrl, content)
            result.StatusCode = HttpStatusCode.OK || result.StatusCode = HttpStatusCode.NotFound

        member this.CancelBuild(conf:ITeamcityConfiguration, buildUrl:string, requeue:bool, cancelingComment:string, cancelingApplication:string) = 
            let content = sprintf "<buildCancelRequest comment='%s Canceled From: %s' readdIntoQueue='%b' />" cancelingComment cancelingApplication requeue
            let result = httpconnector.HttpPostRequestContent(conf, buildUrl, content)
            result.StatusCode = HttpStatusCode.OK || result.StatusCode = HttpStatusCode.NotFound

        member this.CreateNewProject(conf:ITeamcityConfiguration, name:string, id:string, parent:string) = 
            let url = "/app/rest/projects"
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
            let url = "/app/rest/buildTypes"
            httpconnector.HttpPostRequestContent(conf, url, content).StatusCode

        member this.TriggerCheckForChanges(conf:ITeamcityConfiguration, vcsRootId:string) = 
            let url = "/app/rest/debug/vcsCheckingForChangesQueue?locator=vcsRoot:"
            httpconnector.HttpRequest(conf, url, RestSharp.Method.Get) |> ignore

        member this.GetQueuedAndRunningBuildsByBranchAndConfig(conf:ITeamcityConfiguration, branch:string, buildConfig:string) =
            let queuedbuilds = new System.Collections.Generic.List<QueueBuild>()
            let url = sprintf "/app/rest/builds?locator=state:(queued:true,running:true),branch:%s,buildType:%s&fields=build(id,agent,state,status,startEstimate,buildTypeId,href,webUrl,comment,queuedDate,startDate,buildType,percentageComplete,number)" branch buildConfig
            let dataParsed = QueuedBuildResponse.Parse(httpconnector.HttpRequest(conf, url, RestSharp.Method.Get).Content)
            for data in dataParsed.Build do
                queuedbuilds.Add(QueuedBuildFromBuildData(data, branch))
            queuedbuilds
        
        member this.GetQueuedAndRunningBuildsByBranch(conf:ITeamcityConfiguration, branch:string) =
            let queuedbuilds = new System.Collections.Generic.List<QueueBuild>()
            let url = "/app/rest/builds?locator=state:(queued:true,running:true),branch:" + branch + "&fields=build(id,agent,state,status,startEstimate,buildTypeId,href,webUrl,comment,queuedDate,startDate,buildType,percentageComplete,number)"
            let dataParsed = QueuedBuildResponse.Parse(httpconnector.HttpRequest(conf, url, RestSharp.Method.Get).Content)
            for data in dataParsed.Build do                
                queuedbuilds.Add(QueuedBuildFromBuildData(data, branch))
            queuedbuilds

        member this.GetRunningBuilds(conf:ITeamcityConfiguration) =
            let queuedbuilds = new System.Collections.Generic.List<QueueBuild>()
            let url = "/app/rest/builds?locator=state:(running:true)&fields=build(id,agent,state,status,startEstimate,buildTypeId,href,webUrl,comment,queuedDate,startDate,buildType,percentageComplete,number,running-info)"
            let dataParsed = QueuedBuildResponse.Parse(httpconnector.HttpRequest(conf, url, RestSharp.Method.Get).Content)
            for data in dataParsed.Build do                
                queuedbuilds.Add(QueuedBuildFromBuildData(data, ""))
            queuedbuilds

        member this.GetRunningBuildsByBranch(conf:ITeamcityConfiguration, branch:string) =
            let queuedbuilds = new System.Collections.Generic.List<QueueBuild>()
            let url = "/app/rest/builds?locator=state:(running:true),branch:" + branch + "&fields=build(id,agent,state,status,startEstimate,buildTypeId,href,webUrl,comment,queuedDate,startDate,buildType,percentageComplete,number,running-info)"
            let dataParsed = QueuedBuildResponse.Parse(httpconnector.HttpRequest(conf, url, RestSharp.Method.Get).Content)
            for data in dataParsed.Build do                
                queuedbuilds.Add(QueuedBuildFromBuildData(data, branch))
            queuedbuilds

        member this.GetQueuedBuild(conf:ITeamcityConfiguration, urlRef:string, branch:string) =
            let dataContent = httpconnector.HttpRequest(conf, urlRef, RestSharp.Method.Get).Content            
            SingleQueuedBuildFromBuildData(dataContent, branch)

        member this.GetQueuedBuilds(conf:ITeamcityConfiguration) =
            let queuedbuilds = new System.Collections.Generic.List<QueueBuild>()
            let url = "/app/rest/buildQueue?fields=build(id,agent,state,status,startEstimate,buildTypeId,href,webUrl,waitReason,comment,queuedDate,startDate,branchName,buildType,percentageComplete,number)"
            let dataContent = httpconnector.HttpRequest(conf, url, RestSharp.Method.Get).Content
            let dataParsed = QueuedBuildResponse.Parse(dataContent)
            for data in dataParsed.Build do
                if data.BranchName.String.IsSome then
                    queuedbuilds.Add(QueuedBuildFromBuildData(data, data.BranchName.String.Value))
                else
                    queuedbuilds.Add(QueuedBuildFromBuildData(data, ""))
            queuedbuilds
            
        member this.TriggerTeamcityBuild(conf:ITeamcityConfiguration, build:TcBuild, branch:string) =
            let url = "/app/rest/buildQueue"
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
                (this :> ITeamcityConnector).TriggerTeamcityBuild(conf, build, branch, comment, parameters, agentString, attop, "")

        member this.TriggerTeamcityBuild(conf:ITeamcityConfiguration,
                                         build:string,
                                         branch:string,
                                         comment:string,
                                         parameters:System.Collections.Generic.Dictionary<string, string>,
                                         agentString:string,
                                         attop:bool, 
                                         revision:string) =
            let url = "/app/rest/buildQueue"
            let payload = getPayloadWithParametersXml(branch, build, comment,  toMap parameters, agentString, attop, revision)
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
            let url = "/app/rest/buildQueue"
            let payload = getPayloadWithParametersXml(branch, build.Id, comment, toMap arguments, agentString, attop, "")
            let buildreply = httpconnector.HttpPutFileContent(conf, url, payload, "build")
            if tags <> null && tags.Count > 0 then
                Thread.Sleep(3000)
                let data = TriggerBuildResponse.Parse(buildreply)
                // apply tags
                let url = sprintf "/app/rest/builds/id:%i/tags" data.Id
                let payload = getTagPayload(tags)
                httpconnector.HttpPutFileContent(conf, url, payload, "build") |> ignore

        member this.GetPendingChangesForBuildType(conf:ITeamcityConfiguration, buildTypeId:string, branch:string, limitForChanges:int) =
            let buildurl = sprintf "/app/rest/changes?locator=buildType:(id:%s),branch:%s,pending:true" buildTypeId branch
            let contentString = httpconnector.HttpRequest(conf, buildurl, RestSharp.Method.Get).Content
            let fullBuildData = Changes.Parse(contentString)
            let changes = System.Collections.Generic.List<Change>()
            for change in fullBuildData.Change do
                if changes.Count < limitForChanges then
                    let changedata = Change()
                    changedata.Date <- change.Date
                    changedata.Href <- change.Href
                    changedata.Id <- sprintf "%i" change.Id
                    changedata.UserName <- change.Username
                    changedata.Version <- change.Version
                    changedata.WebUrl <- change.WebUrl    
                    let changeComment = ChangeUnique.Parse(httpconnector.HttpRequest(conf, change.Href, RestSharp.Method.Get).Content)
                    changedata.Comment <- changeComment.Comment
                    changes.Add(changedata)

            changes


        member this.GetLog(conf:ITeamcityConfiguration, id:int) =
            let url = sprintf "/downloadBuildLog.html?buildId=%i" id
            httpconnector.HttpRequest(conf, url, RestSharp.Method.Get).Content

        member this.Authenticate(conf:ITeamcityConfiguration) =
            let url = "/app/rest/vcs-roots"
            let answerData = httpconnector.HttpRequest(conf, url, RestSharp.Method.Get)
            if answerData.StatusCode <> Net.HttpStatusCode.OK then
                answerData.Content
            else
                ""

        member this.DownloadArtifact(conf:ITeamcityConfiguration, build:TcBuild, artifactPath:string, outFile:string, useDsk:bool) =
            let url = conf.Hostname.TrimEnd('/') + build.Href + "/artifacts/content/" + artifactPath
            let mutable endFilePath = outFile
            if useDsk then 
                endFilePath <- Path.GetTempFileName()

            let myWebClient = new WebClient()
            if conf.Token = "" then
                myWebClient.Credentials <- new NetworkCredential(conf.Username, conf.Password)
            else                
                myWebClient.Headers.[HttpRequestHeader.Authorization] <- "Bearer " + conf.Token

            myWebClient.DownloadFile(url, endFilePath)

            if useDsk then
                try
                    File.Copy(endFilePath, outFile, true);
                    File.Delete(endFilePath);
                with
                | ex -> 
                    File.Delete(endFilePath)
                    raise(ex)


        member this.DeleteBuildById(conf:ITeamcityConfiguration, id:string) =
            let buildurl = "/app/rest/builds/id:" + id
            let result = httpconnector.HttpDeleteRequest(conf, buildurl)
            result.StatusCode = HttpStatusCode.NoContent || result.StatusCode = HttpStatusCode.NotFound || result.StatusCode = HttpStatusCode.OK

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
            let contentString = httpconnector.HttpRequest(conf, buildurl, RestSharp.Method.Get).Content
            let fullBuildData = UniqueBuildResponse.Parse(contentString)
            let newBuild = new TcBuild()
            newBuild.BuildConfigurationId <- fullBuildData.BuildType.Id
            newBuild.BuildConfigurationName <- fullBuildData.BuildType.Name
            newBuild.Href <- fullBuildData.Href
            newBuild.BuildTypeId <- fullBuildData.BuildTypeId
            newBuild.Id <- fullBuildData.Id
            newBuild.Number <- fullBuildData.Number
            newBuild.State <- fullBuildData.State
            newBuild.Status <- fullBuildData.Status
            newBuild.StatusText <- if contentString.Contains("statusText") then fullBuildData.StatusText else ""
            newBuild.ProblemOccurrencesCount <- if contentString.Contains("problemOccurrences") then fullBuildData.ProblemOccurrences.Count else 0
            newBuild.ProblemOccurrencesHref <- if contentString.Contains("problemOccurrences") then fullBuildData.ProblemOccurrences.Href else ""
            newBuild.WebUrl <- fullBuildData.WebUrl
            newBuild.Branch <- fullBuildData.BranchName
            newBuild.QueuedTime <- ParseDate(fullBuildData.QueuedDate)
            newBuild.StartTime <- ParseDate(fullBuildData.StartDate)
            newBuild.EndTime <- ParseDate(fullBuildData.FinishDate)
            newBuild.Comment <- if contentString.Contains("comment") then try fullBuildData.Comment.Text with | _ -> "" else ""
            newBuild.Revision <-
                if fullBuildData.Revisions.Count > 0 then
                    fullBuildData.Revisions.Revision.[0].Version
                else
                    null

            if contentString.Contains("\"agent\":") then
                if fullBuildData.Agent.JsonValue.ToString().Contains("\"typeId\":") then
                    newBuild.AgentId <- string fullBuildData.Agent.TypeId
                if fullBuildData.Agent.JsonValue.ToString().Contains("\"id\":") then
                    newBuild.AgentId <- string fullBuildData.Agent.Id

                newBuild.AgentName <- if contentString.Contains("agent") then try fullBuildData.Agent.Name with | _ -> "" else ""

            newBuild.TriggerUser <- if contentString.Contains("\"user\":") then try fullBuildData.Triggered.User.Name with | ex -> "" else "" 
            newBuild.TriggerType <- fullBuildData.Triggered.Type
            if fullBuildData.Triggered.Type.ToLower() = "snapshotdependency" then
                newBuild.TriggerBuildTypeId <- if contentString.Contains("\"build\":") then try fullBuildData.Triggered.Build.BuildTypeId with | ex -> "" else "" 
                newBuild.TriggerBuildId <- if contentString.Contains("\"build\":") then try (string fullBuildData.Triggered.Build.Id) with | ex -> "" else ""  

            try
                for prop in fullBuildData.Properties.Property do
                    let propToBuild = BuildProperty()
                    propToBuild.Name <- prop.Name
                    if prop.Inherited.IsSome then
                        propToBuild.Inherited <- prop.Inherited.Value
                    propToBuild.Value <- prop.Value
                    newBuild.Properties.Add(propToBuild)

                if getResultProps then
                    GetResultingProps(newBuild,conf)
            with
            | _ -> ()

            if getArtifacts then
                let restponseArtifacts = ArtifactsPathResponse.Parse(httpconnector.HttpRequest(conf, fullBuildData.Artifacts.Href, RestSharp.Method.Get).Content)
                if restponseArtifacts.Count <> 0 then
                    for artifactElem in restponseArtifacts.File do
                        let artifcat = new Artifact()
                        artifcat.FileName <- artifactElem.Name
                        newBuild.Artifacts.Add(artifcat)

            let mutable changeLog = ""
            if getChanges then
                try
                    let buildurlchanges = sprintf "/app/rest/changes?locator=build:(id:%s)&fields=count,change:(id,version,username,date,href,webUrl,files)" id
                    let changesData = Changes.Parse(httpconnector.HttpRequest(conf, buildurlchanges, RestSharp.Method.Get).Content)         
                    if changesData.Count <> 0 then
                        for change in changesData.Change do
                            let changedata = Change()
                            changedata.Date <- change.Date
                            changedata.Href <- change.Href
                            changedata.Id <- sprintf "%i" change.Id
                            changedata.UserName <- change.Username
                            changedata.Version <- change.Version
                            changedata.WebUrl <- change.WebUrl
                            
                            if newBuild.Revision = "" || newBuild.Revision = null then
                                newBuild.Revision <- change.Version

                            if change.Files.Count <> 0 then
                                for file in change.Files.File do 
                                    changedata.ListofChangedFiles.Add(file.File)
                            let change = ChangeUnique.Parse(httpconnector.HttpRequest(conf, change.Href, RestSharp.Method.Get).Content)
                            changedata.Comment <- change.Comment
                            newBuild.ChangesData.Add(changedata)
                            changeLog <- changeLog + change.Username + " : " + change.Comment + "\r\n"
                with
                | ex -> ()
            newBuild.Changes <- changeLog

            if getTests then
                GetTests(newBuild, conf, false)

            if getProblems then 
                GetProblems(newBuild,conf)
            newBuild


        member this.GetFailedBuildsFromConfiguration(conf:ITeamcityConfiguration, buildConfig:string, branch:string) =

            let branchToUse = 
                if branch <> "" then
                    sprintf "branch:%s," branch
                else
                    ""

            let buildurl = sprintf "/app/rest/builds/?locator=buildType:%s,%sstatus:FAILURE,count:1000" buildConfig branchToUse
            let data = BuildSummaryResponse.Parse(httpconnector.HttpRequest(conf, buildurl, RestSharp.Method.Get).Content)
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

        member this.GetBuildConfigurationsFromProject(conf:ITeamcityConfiguration, projectName:string) =
            let buildurlFirst = sprintf "/app/rest/buildTypes?locator=affectedProject:(id:%s)" projectName
            let dataAnswer = httpconnector.HttpRequest(conf, buildurlFirst, RestSharp.Method.Get).Content
            let dataFirst = BuildTypeResponseProjectRecursive.Parse(dataAnswer)
            let builds = System.Collections.Generic.List<TCBuildConfigurationType>()
            if dataAnswer.Contains("\"buildType\":") then
                for buildtype in dataFirst.BuildType do                    
                    let newBuild = new TCBuildConfigurationType()
                    newBuild.Href <- buildtype.Href
                    newBuild.Id <- buildtype.Id
                    newBuild.Name <- buildtype.Name
                    newBuild.ProjectName <- buildtype.ProjectName
                    newBuild.WebUrl <- buildtype.WebUrl
                    newBuild.ProjectId <- buildtype.ProjectId
                    builds.Add(newBuild)
            builds

        member this.GetLastBuildFromBuildConfiguration(conf:ITeamcityConfiguration, buildTypeId:string, branch:string) =            
            let branchToUse = 
                if branch <> "" then
                    sprintf "branch:%s," branch
                else
                    ""

            let buildurlFirst = sprintf "/app/rest/buildTypes?locator=id:%s&fields=buildType(id,name,builds($locator(%scount:1),build(id,startDate,finishDate,queuedDate,statusText,status,href,state,buildTypeId,webUrl,number,comment)))" buildTypeId branchToUse
            let dataS = httpconnector.HttpRequest(conf, buildurlFirst, RestSharp.Method.Get)
            let dataAnswer = dataS.Content
            let builds = System.Collections.Generic.List<TcBuild>()
            if dataAnswer <> "" then
                let dataFirst = QueryFailedBuilds.Parse(dataAnswer)            
                if dataAnswer.Contains("\"buildType\":") && dataAnswer.Contains("\"builds\":") then
                    for buildtype in dataFirst.BuildType do
                        for build in buildtype.Builds.Build do
                            let newBuild = new TcBuild()
                            newBuild.BuildConfigurationName <- buildtype.Name.Value
                            newBuild.Href <- build.Href
                            newBuild.BuildTypeId <- build.BuildTypeId
                            newBuild.Id <- build.Id.ToString()
                            newBuild.Number <- build.Number.String.Value
                            newBuild.State <- build.State
                            newBuild.StatusText <- if dataAnswer.Contains("\"statusText\":") then try build.StatusText with | _ -> "" else ""
                            newBuild.Status <- build.Status
                            if build.Comment.IsSome then
                                newBuild.Comment <- build.Comment.Value.Text
                            newBuild.WebUrl <- build.WebUrl
                            newBuild.Branch <- branch
                            newBuild.StartTime <- DateTime.ParseExact(build.StartDate.Value.Split('+').[0], "yyyyMMddTHHmmss", CultureInfo.InvariantCulture)
                            newBuild.QueuedTime <- DateTime.ParseExact(build.QueuedDate.Value.Split('+').[0], "yyyyMMddTHHmmss", CultureInfo.InvariantCulture)
                            newBuild.EndTime <- DateTime.ParseExact(build.FinishDate.Value.Split('+').[0], "yyyyMMddTHHmmss", CultureInfo.InvariantCulture)
                            builds.Add(newBuild)
            builds

        member this.GetLastBuildsFromProject(conf:ITeamcityConfiguration, projectName:string, branch:string, isDefault:bool) =

            let urlToUse =
                if branch = "" || isDefault then
                    sprintf "/app/rest/buildTypes?locator=affectedProject:(id:%s)&fields=buildType(id,comment,name,builds($locator(branch:(default:true),count:1),build(id,startDate,finishDate,queuedDate,statusText,status,href,state,buildTypeId,webUrl,number,comment,branchName)))" projectName
                else
                    sprintf "/app/rest/buildTypes?locator=affectedProject:(id:%s)&fields=buildType(id,comment,name,builds($locator(branch:(name:(matchType:equals,value:(%s))),count:1),build(id,startDate,finishDate,queuedDate,statusText,status,href,state,buildTypeId,webUrl,number,comment,branchName)))" projectName branch

            let dataS = httpconnector.HttpRequest(conf, urlToUse, RestSharp.Method.Get)
            let dataAnswer = dataS.Content
            let builds = System.Collections.Generic.List<TcBuild>()
            if dataAnswer <> "" then
                try
                    let dataFirst = QueryFailedBuilds.Parse(dataAnswer)                            
                    if dataAnswer.Contains("\"buildType\":") && dataAnswer.Contains("\"builds\":") then
                        for buildtype in dataFirst.BuildType do
                            for build in buildtype.Builds.Build do
                                let newBuild = new TcBuild()
                                newBuild.BuildConfigurationName <- buildtype.Name.Value
                                newBuild.Href <- build.Href
                                newBuild.BuildTypeId <- build.BuildTypeId
                                newBuild.Id <- build.Id.ToString()
                                newBuild.Number <- build.Number.ToString()
                                newBuild.State <- build.State
                                newBuild.StatusText <- if dataAnswer.Contains("\"statusText\":") then try build.StatusText with | _ -> "" else ""
                                newBuild.Status <- build.Status
                                newBuild.WebUrl <- build.WebUrl
                                newBuild.Branch <- build.BranchName
                                if build.Comment.IsSome then
                                    newBuild.Comment <- build.Comment.Value.Text

                                newBuild.StartTime <- DateTime.ParseExact(build.StartDate.Value.Split('+').[0], "yyyyMMddTHHmmss", CultureInfo.InvariantCulture)
                                newBuild.QueuedTime <- DateTime.ParseExact(build.QueuedDate.Value.Split('+').[0], "yyyyMMddTHHmmss", CultureInfo.InvariantCulture)
                                newBuild.EndTime <- DateTime.ParseExact(build.FinishDate.Value.Split('+').[0], "yyyyMMddTHHmmss", CultureInfo.InvariantCulture)
                                builds.Add(newBuild)
                with
                | _ -> ()
            builds

        member this.GetFailedBuildsFromProject(conf:ITeamcityConfiguration, projectName:string, branch:string) =
            let branchToUse = 
                if branch <> "" then
                    sprintf "branch:%s," branch
                else
                    ""                    
            let buildurlFirst = sprintf "/app/rest/builds/?locator=affectedProject:(id:%s),%sstatus:FAILURE,count:1000" projectName branchToUse
            let dataFirst = BuildSummaryResponse.Parse(httpconnector.HttpRequest(conf, buildurlFirst, RestSharp.Method.Get).Content)
            let builds = System.Collections.Generic.List<TcBuild>()
            if dataFirst.Count > 0 then
                for build in dataFirst.Build do
                    let buildurl = sprintf "/app/rest/builds/?locator=buildType:%s,%scount:1000" build.BuildTypeId branchToUse
                    let data = BuildSummaryResponse.Parse(httpconnector.HttpRequest(conf, buildurl, RestSharp.Method.Get).Content)
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

        member this.GetBuildsFromBuildConfiguration(conf:ITeamcityConfiguration,
                buildConf:string,
                branch:string) =
                (this :> ITeamcityConnector).GetBuildsFromBuildConfiguration(conf, buildConf, branch, false, 100, false, false, false, false)

        member this.GetBuildsFromBuildConfiguration(conf:ITeamcityConfiguration,
                buildConf:string,
                branch:string,
                getTests:bool,
                lookupLimitLocator:int,
                getProps:bool,
                getResultingProps:bool,
                getArtifacts:bool,
                getProblems:bool) =

            let lookupLimitLocatorToUse =
                sprintf "lookupLimit:%i," lookupLimitLocator

            let deepLimitLocator =
                if lookupLimitLocator > 100 then
                    sprintf ",start:0,count:%i" lookupLimitLocator
                else
                    ""

            let branchLocator = 
                if branch = "" then
                    ""
                else
                    ",branch:" + branch

            let buildurl = "/app/rest/builds/?locator=" + lookupLimitLocatorToUse + "buildType:" + buildConf + branchLocator + deepLimitLocator

            GetAdditionBuildInformationforBuildTypes(buildurl, conf, branch, getTests, getProps, getResultingProps, getArtifacts, getProblems, "")

        member this.GetBuildsFromBuildConfiguration(conf:ITeamcityConfiguration,
            buildConf:string,
            branch:string,
            getTests:bool,
            lookupLimitLocator:int,
            getProps:bool,
            getResultingProps:bool,
            getArtifacts:bool,
            getProblems:bool,
            ?sinceDate:DateTime,
            ?untilDate:DateTime) =

            let lookupLimitLocatorToUse =
                sprintf "lookupLimit:%i," lookupLimitLocator

            let sinceDateLocator =
                if sinceDate.IsSome then
                    sprintf "sinceDate:%s-0000," (sinceDate.Value.ToString("yyyyMMddTHHmmss"))
                else
                    ""

            let untilDateLocator =
                if untilDate.IsSome then
                    sprintf "untilDate:%s-0000," (untilDate.Value.ToString("yyyyMMddTHHmmss"))
                else
                    ""

            let deepLimitLocator =
                if lookupLimitLocator > 100 then
                    sprintf ",start:0,count:%i" lookupLimitLocator
                else
                    ""

            let branchLocator = 
                if branch = "" then
                    ""
                else
                    ",branch:" + branch

            let buildurl = "/app/rest/builds/?locator=" + lookupLimitLocatorToUse + sinceDateLocator + untilDateLocator + "buildType:" + buildConf + branchLocator + deepLimitLocator

            GetAdditionBuildInformationforBuildTypes(buildurl, conf, branch, getTests, getProps, getResultingProps, getArtifacts, getProblems, "")
        
        member this.GetBuildInfoFromBuildConfiguration(conf:ITeamcityConfiguration,
            buildConf:string,
            branch:string) =
            (this :> ITeamcityConnector).GetBuildInfoFromBuildConfiguration(conf, buildConf, branch, "", 100)
        
        member this.GetBuildInfoFromBuildConfiguration(conf:ITeamcityConfiguration,
            buildConf:string,
            branch:string,
            regxForResultProps:string,
            lookupLimitLocator:int) =

            let count =
                if lookupLimitLocator > 100 then
                    lookupLimitLocator
                else
                    100

            let buildurl =
                if branch = "master" || branch = "" then
                    sprintf "/app/rest/builds/?locator=defaultFilter:false,branch:(policy:ALL_BRANCHES,default:true),state:(finished:true),buildType:(id:%s),start:0,count:%i,lookupLimit:%i" buildConf count lookupLimitLocator
                else
                    sprintf "/app/rest/builds/?locator=defaultFilter:false,branch:(policy:ALL_BRANCHES,name:(matchType:equals,value:(%s))),state:(finished:true),buildType:(id:%s),start:0,count:%i,lookupLimit:%i" branch buildConf count lookupLimitLocator

            GetAdditionBuildInformationforBuildTypes(buildurl, conf, branch, false, false, false, false, false, regxForResultProps)

        member this.GetBuildInfoFromBuildConfiguration(conf:ITeamcityConfiguration,
            buildConf:string,
            branch:string,
            regxForResultProps:string,
            lookupLimitLocator:int,            
            ?sinceDate:DateTime,
            ?untilDate:DateTime) =

            let count =
                if lookupLimitLocator > 100 then
                    lookupLimitLocator
                else
                    100

            let sinceDateLocator =
                if sinceDate.IsSome then
                    sprintf "sinceDate:%s-0000," (sinceDate.Value.ToString("yyyyMMddTHHmmss"))
                else
                    ""

            let untilDateLocator =
                if untilDate.IsSome then
                    sprintf "untilDate:%s-0000," (untilDate.Value.ToString("yyyyMMddTHHmmss"))
                else
                    ""

            let buildurl =
                if branch = "master" || branch = "" then
                    sprintf "/app/rest/builds/?locator=defaultFilter:false,branch:(policy:ALL_BRANCHES,default:true),state:(finished:true),buildType:(id:%s),start:0,count:%i,%s%slookupLimit:%i" buildConf count sinceDateLocator untilDateLocator lookupLimitLocator
                else
                    sprintf "/app/rest/builds/?locator=defaultFilter:false,branch:(policy:ALL_BRANCHES,name:(matchType:equals,value:(%s))),state:(finished:true),buildType:(id:%s),start:0,count:%i,%s%slookupLimit:%i" branch buildConf count sinceDateLocator untilDateLocator lookupLimitLocator

            GetAdditionBuildInformationforBuildTypes(buildurl, conf, branch, false, false, false, false, false, regxForResultProps)
            
        member this.GetCanceledBuilds(conf:ITeamcityConfiguration,
                                                    buildConf:string,
                                                    branch:string) =

            let builds = System.Collections.Generic.List<TcBuild>()
            try
               let buildurl = "/app/rest/builds/" + "?locator=buildType:" + buildConf + ",canceled:all,status:UNKNOWN"
               let data = BuildResponse.Parse(httpconnector.HttpRequest(conf, buildurl, RestSharp.Method.Get).Content)

               if data.Count > 0 then
                    for build in data.Build do
                        let contentString = httpconnector.HttpRequest(conf, build.Href, RestSharp.Method.Get).Content
                        let fullBuildData = UniqueBuildResponse.Parse(contentString)
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
                        if contentString.Contains("\"agent\":") then
                            if fullBuildData.Agent.JsonValue.ToString().Contains("\"typeId\":") then
                                newBuild.AgentId <- string fullBuildData.Agent.TypeId
                            if fullBuildData.Agent.JsonValue.ToString().Contains("\"id\":") then
                                newBuild.AgentId <- string fullBuildData.Agent.Id

                            newBuild.AgentName <- if contentString.Contains("agent") then try fullBuildData.Agent.Name with | _ -> "" else ""
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

        member this.SetVcsRootsProperty(conf:ITeamcityConfiguration, vcsRootId:string, propertyName:string, propertyValue:string) = 
            let url =
                if propertyName = "modificationCheckInterval" then
                    sprintf "/app/rest/vcs-roots/id:%s/%s" vcsRootId propertyName
                else
                    sprintf "/app/rest/vcs-roots/id:%s/properties/%s" vcsRootId propertyName

            let result = httpconnector.HttpPutTxtContent(conf, url, propertyValue)
            result.Content = propertyValue

        member this.GetVcsRootsSimple(conf:ITeamcityConfiguration, count:int, projectId:string) = 
            let projectLocator = 
                if projectId <> "" && projectId <> null then
                    sprintf "affectedProject:%s" projectId
                else
                    sprintf "affectedProject:_Root"

            let fields = "&fields=vcs-root(id,modificationCheckInterval,href,name,properties($long,$locator:name:(value:(url%7Cpush_url%7CteamcitySshKey),matchType:matches)))"
            let url = sprintf "/app/rest/vcs-roots?locator=%s,count:%i%s" projectLocator count fields
            let reply = httpconnector.HttpRequest(conf, url, RestSharp.Method.Get).Content
            let vcsRoots = new System.Collections.Generic.List<VcRoot>()
            let dataParsed = VcsRootsSingleResponse.Parse(reply)
            for vcs in dataParsed.VcsRoot do
                let vcsRoot = new VcRoot()
                vcsRoot.Href <- vcs.Href.Value
                vcsRoot.Name <- vcs.Name.Value
                vcsRoot.Id <- vcs.Id
                if vcs.ModificationCheckInterval.IsSome then
                    vcsRoot.ModificationCheckInterval <- int64(vcs.ModificationCheckInterval.Value)
                for property in vcs.Properties.Property do
                    vcsRoot.Properties.Add(property.Name, property.Value) |> ignore
                vcsRoots.Add(vcsRoot)
            vcsRoots                

        member this.GetVcsRoots(conf:ITeamcityConfiguration, count:int, projectId:string, details:bool) = 
            let projectLocator = 
                if projectId <> "" && projectId <> null then
                    sprintf ",affectedProject:%s" projectId
                else
                    ""
            let url = sprintf "/app/rest/vcs-roots?locator=count:%i%s" count projectLocator
            let reply = httpconnector.HttpRequest(conf, url, RestSharp.Method.Get).Content
            let vcsRoots = new System.Collections.Generic.List<VcRoot>()
            let dataParsed = VcsRootsResponse.Parse(reply)
            for vcs in dataParsed.VcsRoot do
                let vcsRoot = new VcRoot()
                vcsRoot.Href <- vcs.Href
                vcsRoot.Name <- vcs.Name
                vcsRoot.Id <- vcs.Id
                if details then
                    let detailsurlReply = httpconnector.HttpRequest(conf, vcs.Href, RestSharp.Method.Get).Content
                    let dataParsedDetails = VcsRootDetailsReponse.Parse(detailsurlReply)
                    for property in dataParsedDetails.Properties.Property do
                        if property.Value.String.IsSome then
                            vcsRoot.Properties.Add(property.Name, property.Value.String.Value) |> ignore
                ()
                vcsRoots.Add(vcsRoot)
            vcsRoots

        member this.GetAllProjects(conf:ITeamcityConfiguration, configuration:string) =
            
            let url = 
                if configuration = "" then
                    "/app/rest/projects/id:_Root"
                else
                    "/app/rest/projects/id:" + configuration

            GetProjectsFromReply(httpconnector.HttpRequest(conf, url, RestSharp.Method.Get).Content, conf)

        member this.GetAllUsers(conf:ITeamcityConfiguration) =
            try
            let url = "/app/rest/users"
            let reply = httpconnector.HttpRequest(conf, url, RestSharp.Method.Get).Content
            let users = new System.Collections.Generic.List<TcUser>()
            let dataParsed = AllUsersResponse.Parse(reply)
            if dataParsed.Count > 0 then
                for user in dataParsed.User do
                    let newUser = new TcUser()
                    newUser.Id <- user.Id.ToString()
                    newUser.Name <- user.Name
                    newUser.Href <- user.Href
                    newUser.UserName <- user.Username
                    let replyDetails = httpconnector.HttpRequest(conf, user.Href, RestSharp.Method.Get).Content
                    let dataParsedDetails = UserRespose.Parse(replyDetails)
                    newUser.Email <- dataParsedDetails.Email
                    users.Add(newUser)
            users
            with _ ->  System.Collections.Generic.List<TcUser>()
            
         member this.GetUserByDisplayName(conf:ITeamcityConfiguration,name:string) =
             try
             let encodedName= System.Web.HttpUtility.HtmlEncode(name)
             let url = "/app/rest/users/name:" + encodedName
             let reply = httpconnector.HttpRequest(conf, url, RestSharp.Method.Get).Content
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
             let reply = httpconnector.HttpRequest(conf, url, RestSharp.Method.Get).Content
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
            let reply = httpconnector.HttpRequest(conf, url, RestSharp.Method.Get).Content
            let dataParsed = UserRespose.Parse(reply)
            let newUser = new TcUser()
            newUser.Id <- try dataParsed.Id.ToString() with | _ -> ""
            newUser.Name <- try dataParsed.Name with | _ -> ""
            newUser.Href <- try dataParsed.Href with | _ -> ""
            newUser.UserName <- try dataParsed.Username with | _ -> ""
            newUser.Email <- try dataParsed.Email with | _ -> ""
            newUser
            with _ -> new TcUser()
        
        member this.GetUser(conf:ITeamcityConfiguration) = 
            try
                let url = "/app/rest/ui/users/current?fields=id,name,email,username,href"
                let reply = httpconnector.HttpRequest(conf, url, RestSharp.Method.Get).Content
                let dataParsed = UserRespose.Parse(reply)

                let newUser = new TcUser()
                newUser.Id <- try dataParsed.Id.ToString() with | _ -> ""
                newUser.Name <- try dataParsed.Name with | _ -> ""
                newUser.Href <- try dataParsed.Href with | _ -> ""
                newUser.UserName <- try dataParsed.Username with | _ -> ""
                newUser.Email <- try dataParsed.Email with | _ -> ""
                newUser
            with _ -> TcUser()

        member this.GetUserByUserName(conf:ITeamcityConfiguration,username:string) =
            try
                let url = "/app/rest/users/username:"+username
                let reply = httpconnector.HttpRequest(conf, url, RestSharp.Method.Get).Content
                let dataParsed = UserRespose.Parse(reply)
                let newUser = new TcUser()
                newUser.Id <- try dataParsed.Id.ToString() with | _ -> ""
                newUser.Name <- try dataParsed.Name with | _ -> ""
                newUser.Href <- try dataParsed.Href with | _ -> ""
                newUser.UserName <- try dataParsed.Username with | _ -> ""
                newUser.Email <- try dataParsed.Email with | _ -> ""
                newUser
            with _ -> TcUser()
