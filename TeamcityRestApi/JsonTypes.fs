namespace TeamcityRestConnector

open FSharp.Data

type QueryFailedBuilds = JsonProvider<"""
{
    "buildType": [
        {
            "id": "TeklaStructuresIntegrationTests_Farmi_FarmiOnMaster_FarmiModelsUpdate",
            "builds": {
                "build": []
            }
        },
        {
            "id": "TeklaStructuresIntegrationTests_Farmi_FarmiOnMaster_PinpointFailedTest",
            "name": "Pinpoint",
            "builds": {
                "build": [
                    {
                        "id": 15872895,
                        "buildTypeId": "TeklaStructuresIntegrationTests_Farmi_FarmiOnMaster_PinpointFailedTest",
                        "number": "5assa666",
                        "status": "FAILURE",
                        "state": "finished",
                        "branchName": "master",
                        "statusText": "asdasd",
                        "queuedDate": "20200405T054327+0300",
                        "startDate": "20200405T080713+0300",
                        "finishDate": "20200405T081651+0300",
                        "href": "/app/rest/builds/id:15872895",
                        "webUrl": "http://teamcity/viewLog.html?buildId=15872895&buildTypeId=TeklaStructuresIntegrationTests_Farmi_FarmiOnMaster_PinpointFailedTest",
                        "comment": {
                            "timestamp": "20200903T204319+0300",
                            "text": "Triggered from TafConsole by buildmaster in R-BUILDAGENT61",
                            "user": {}
                        }
                    }
                ]
            }
        },
        {
            "id": "TafTemplateConfiguration",
            "builds": {
                "build": []
            }
        },
        {
            "id": "TeklaStructuresIntegrationTests_Farmi_FarmiOnMaster_TeamcityTicketValidatorMaste",
            "builds": {
                "build": []
            }
        },
        {
            "id": "FTC_122_TeklaStructuresIntegrationTestsFarmiFarmiOnMasterAnalysisandDesignAnaly",
            "builds": {
                "build": [
                    {
                        "id": 15224049,
                        "buildTypeId": "FTC_122_TeklaStructuresIntegrationTestsFarmiFarmiOnMasterAnalysisandDesignAnaly",
                        "number": "216",
                        "status": "FAILURE",
                        "state": "finished",
                        "branchName": "master",
                        "defaultBranch": true,
                        "statusText": "asdasd",
                        "href": "/app/rest/builds/id:15224049",
                        "webUrl": "http://teamcity/viewLog.html?buildId=15224049&buildTypeId=FTC_122_TeklaStructuresIntegrationTestsFarmiFarmiOnMasterAnalysisandDesignAnaly"
                    }
                ]
            }
        },
        {
            "id": "FTC_13_TeklaStructuresIntegrationTestsFarmiFarmiOnMasterAnalysisandDesignAnalys",
            "builds": {
                "build": []
            }
        },
        {
            "id": "FTC_8932_TeklaStructuresIntegrationTestsFarmiFarmiOnMasterUserInterfaceProperty",
            "builds": {
                "build": [
                    {
                        "id": 15636905,
                        "buildTypeId": "FTC_8932_TeklaStructuresIntegrationTestsFarmiFarmiOnMasterUserInterfaceProperty",
                        "number": "93",
                        "status": "FAILURE",
                        "state": "finished",
                        "branchName": "master",
                        "statusText": "asdasd",
                        "defaultBranch": true,
                        "href": "/app/rest/builds/id:15636905",
                        "webUrl": "http://teamcity/viewLog.html?buildId=15636905&buildTypeId=FTC_8932_TeklaStructuresIntegrationTestsFarmiFarmiOnMasterUserInterfaceProperty"
                    }
                ]
            }
        }
    ]
}
""">

type BuildSummaryResponse = JsonProvider<"""
{
    "count": 2,
    "href": "/app/rest/builds/?locator=affectedProject:%28id:TestConfig%29,branch:master,status:FAILURE,count:1000",
    "nextHref": "/app/rest/builds/?locator=affectedProject:(id:TestConfig),branch:master,status:FAILURE,count:1000,start:81,lookupLimit:10000",
    "build": [
        {
            "id": 1587401,
            "buildTypeId": "FTC_3034_TeklaStructuresIntegrationTestsFarmiFarmiOnMasterPerformanceCore",
            "number": "14",
            "status": "FAILURE",
            "state": "finished",
            "branchName": "master",
            "defaultBranch": true,
            "href": "/app/rest/builds/id:15874018",
            "webUrl": "http://teamcity/viewLog.html?buildId=15874018&buildTypeId=FTC_3034_TeklaStructuresIntegrationTestsFarmiFarmiOnMasterPerformanceCore"
        },
        {
            "id": 1587391,
            "buildTypeId": "FTC_31_TeklaStructuresIntegrationTestsFarmiFarmiOnMasterInteroperabilityIFC",
            "number": "119",
            "status": "FAILURE",
            "state": "finished",
            "branchName": "master",
            "defaultBranch": true,
            "href": "/app/rest/builds/id:15873911",
            "webUrl": "http://teamcity/viewLog.html?buildId=15873911&buildTypeId=FTC_31_TeklaStructuresIntegrationTestsFarmiFarmiOnMasterInteroperabilityIFC"
        }
    ]
}
""">

type ResultingProperties = JsonProvider<"""
{
    "count": 413,
    "property": [
        {
            "name": "build.counter",
            "value": "10asda80"
        },
        {
            "name": "build.number",
            "value": "10asdas80"
        }
    ]
}
""">

type ArtifactsPathResponse = JsonProvider<"""
{
    "count": 3,
    "file": [
        {
            "name": "OpenApiChanges.html",
            "size": 28595,
            "modificationTime": "20181201T232455+0200",
            "href": "/app/rest/builds/id:13051444/artifacts/metadata/OpenApiChanges.html",
            "content": {
                "href": "/app/rest/builds/id:13051444/artifacts/content/OpenApiChanges.html"
            }
        },
        {
            "name": "TeklaStructuresSoftware_x64-99.1.41587.info",
            "size": 146,
            "modificationTime": "20181201T234037+0200",
            "href": "/app/rest/builds/id:13051444/artifacts/metadata/TeklaStructuresSoftware_x64-99.1.41587.info",
            "content": {
                "href": "/app/rest/builds/id:13051444/artifacts/content/TeklaStructuresSoftware_x64-99.1.41587.info"
            }
        },
        {
            "name": "TeklaStructuresSoftware_x64-99.1.41587.zip",
            "size": 1093441350,
            "modificationTime": "20181201T234103+0200",
            "href": "/app/rest/builds/id:13051444/artifacts/metadata/TeklaStructuresSoftware_x64-99.1.41587.zip",
            "content": {
                "href": "/app/rest/builds/id:13051444/artifacts/content/TeklaStructuresSoftware_x64-99.1.41587.zip"
            }
        }
    ]
}
""">

type AgentDetails = JsonProvider<"""
{
    "id": 39,
    "name": "agent",
    "typeId": 39,
    "connected": true,
    "enabled": true,
    "authorized": true,
    "uptodate": true,
    "ip": "10.42.72.107",
    "href": "/app/rest/agents/id:39",
    "webUrl": "http://teamcity/agentDetails.html?id=39&agentTypeId=39&realAgentName=agent",
    "enabledInfo": {
        "status": false,
        "comment": {
            "timestamp": "20200803T215811+0300",
            "text": "Installed VS2019 16.5",
            "user": {
                "username": "buildmaster",
                "name": "Buildmaster",
                "id": 6,
                "href": "/app/rest/users/id:6"
            }
        }
    },
    "authorizedInfo": {
        "status": true,
        "comment": {
            "timestamp": "20200318T154955+0200",
            "text": "Installed VS2019 16.5",
            "user": {
                "username": "user",
                "name": "Name",
                "id": 1186,
                "href": "/app/rest/users/id:1186"
            }
        }
    },
    "properties": {
        "count": 302,
        "property": [
            {
                "name": "DotNetCLI",
                "value": "2.1.500"
            },
            {
                "name": "DotNetCLI_Path",
                "value": "C:\\Program Files\\dotnet\\dotnet.exe"
            }
        ]
    },
    "pool": {
        "id": 2,
        "name": "Work NUnit - Buildmast Account",
        "href": "/app/rest/agentPools/id:2"
    }
}
""">
type AgentsResponse = JsonProvider<"""
{
    "count": 66,
    "href": "/app/rest/agents",
    "agent": [
        {
            "id": 39,
            "name": "agetnt1",
            "typeId": 39,
            "connected": true,
            "enabled": false,
            "authorized": true,
            "href": "/app/rest/agents/id:39",
            "webUrl": "http://teamcity/agentDetails.html?id=39&agentTypeId=39&realAgentName=agetnt1"
        },
        {
            "id": 209,
            "name": "l-buildagent-2",
            "typeId": 209,
            "ip": "10.42.64.216",
            "href": "/app/rest/agents/id:209",
            "webUrl": "http://teamcity/agentDetails.html?id=209&agentTypeId=209&realAgentName=l-buildagent-2",
            "pool": {
                "id": 13,
                "name": "linux-Osx",
                "href": "/app/rest/agentPools/id:13"
            }
        }
    ]
}""">

type VcsRootDetailsReponse = JsonProvider<"""
{
    "id": "TsDailyBranches_InstallersAndCopy_2016andAboveEnvironmentSlimVersions",
    "name": "2016 and above environment slim versions",
    "vcsName": "jetbrains.git",
    "href": "/app/rest/vcs-roots/id:TsDailyBranches_InstallersAndCopy_2016andAboveEnvironmentSlimVersions",
    "project": {
        "id": "TeklaStructuresBuilds",
        "name": "Tekla Structures",
        "parentProjectId": "_Root",
        "href": "/app/rest/projects/id:TeklaStructuresBuilds",
        "webUrl": "http://teamcity/project.html?projectId=TeklaStructuresBuilds"
    },
    "properties": {
        "count": 11,
        "property": [
            {
                "name": "agentCleanFilesPolicy",
                "value": "ALL_UNTRACKED"
            },
            {
                "name": "agentCleanPolicy",
                "value": "ALWAYS"
            },
            {
                "name": "authMethod",
                "value": "TEAMCITY_SSH_KEY"
            },
            {
                "name": "branch",
                "value": "refs/heads/tc-default"
            },
            {
                "name": "ignoreKnownHosts",
                "value": "true"
            },
            {
                "name": "submoduleCheckout",
                "value": "CHECKOUT"
            },
            {
                "name": "teamcity:branchSpec",
                "value": "+:refs/heads/(201*)"
            },
            {
                "name": "teamcitySshKey",
                "value": "teamcity-bm"
            },
            {
                "name": "url",
                "value": "ssh://git@bitbucket.tekla.com:7999/clo/tsenvironmentsslim.git"
            },
            {
                "name": "username",
                "value": "teamcity"
            },
            {
                "name": "usernameStyle",
                "value": "NAME"
            }
        ]
    },
    "vcsRootInstances": {
        "href": "/app/rest/vcs-root-instances?locator=vcsRoot:(id:TsDailyBranches_InstallersAndCopy_2016andAboveEnvironmentSlimVersions)"
    }
}""">

type VcsRootsSingleResponse = JsonProvider<"""
{
    "vcs-root": [
        {
            "id": "TeklaStructuresExternalComponents_Construsoft_TeklaExtensions_AutomaticSplicin_5",
            "modificationCheckInterval": 60000000,
            "href": "/app/rest/vcs-roots/id:TeklaStructuresExternalComponents_Construsoft_TeklaExtensions_AutomaticSplicin_5",
            "name": "ssh://git@bitbucket.trimble.tools/tsia/automaticsplicingtool.git",
            "properties": {
                "count": 3,
                "property": [
                    {
                        "name": "push_url",
                        "value": "ssh://git@bitbucket.trimble.tools/tsia/automaticsplicingtool.git"
                    },
                    {
                        "name": "teamcitySshKey",
                        "value": "svc_tekla_structures-etools"
                    },
                    {
                        "name": "url",
                        "value": "ssh://git@bitbucket.trimble.tools/tsia/automaticsplicingtool.git"
                    }
                ]
            }
        },
        {
            "id": "TeklaStructuresExternalComponents_Construsoft_TeklaExtensions_AutomaticSplicin_5",
            "href": "/app/rest/vcs-roots/id:TeklaStructuresExternalComponents_Construsoft_TeklaExtensions_AutomaticSplicin_5",
            "name": "ssh://git@bitbucket.trimble.tools/tsia/automaticsplicingtool.git",
            "properties": {
                "count": 3,
                "property": [
                    {
                        "name": "teamcitySshKey",
                        "value": "svc_tekla_structures-etools"
                    },
                    {
                        "name": "url",
                        "value": "ssh://git@bitbucket.trimble.tools/tsia/automaticsplicingtool.git"
                    }
                ]
            }
        },
        {
            "id": "TeklaStructuresExternalComponents_Construsoft_TeklaExtensions_ContinuousBeamRe_3",
            "modificationCheckInterval": 60000000,
            "properties": {
                "count": 3,
                "property": [
                    {
                        "name": "push_url",
                        "value": "ssh://git@bitbucket.trimble.tools/tsia/continuousbeamreinforcement.git"
                    },
                    {
                        "name": "teamcitySshKey",
                        "value": "svc_tekla_structures-etools"
                    },
                    {
                        "name": "url",
                        "value": "ssh://git@bitbucket.trimble.tools/tsia/continuousbeamreinforcement.git"
                    }
                ]
            }
        }
    ]
} """>

type VcsRootsResponse = JsonProvider<"""
{
"count": 2,
"href": "/app/rest/vcs-roots?locator=count:2",
"nextHref": "/app/rest/vcs-roots?locator=count:2,start:2",
"vcs-root": [
    {
        "id": "TsDailyBranches_InstallersAndCopy_2016andAboveEnvironmentSlimVersions",
        "name": "2016 and above environment slim versions",
        "href": "/app/rest/vcs-roots/id:TsDailyBranches_InstallersAndCopy_2016andAboveEnvironmentSlimVersions"
    },
    {
        "id": "TsDailyBranches_Win32x642016andAbove_2016andAboveEnvironmentsFastVersions",
        "name": "2016 and above environments fast versions",
        "href": "/app/rest/vcs-roots/id:TsDailyBranches_Win32x642016andAbove_2016andAboveEnvironmentsFastVersions"
    }
]
}
""">

type AllUsersResponse = JsonProvider<""" 
{
    "count": "2",
        "user": [
           {
              "username": "MADJ",
              "name": "Mark Double Johnson",
              "id": "2",
              "href": "/app/rest/users/id:2"
           },
           {
              "username": "XOXO",
              "name": "XO XO",
              "id": "5",
              "href": "/app/rest/users/id:5"
           }
        ]
}
""">

type UserRespose = JsonProvider<"""
{
    "username": "elmgu",
    "name": "Gumaa El Motasim",
    "id": "16",
    "email": "ElMotasim.Gumaa@trimble.com",
    "lastLogin": "19991008T193504+0300",
    "href": "/app/rest/users/id:16",
    "properties": {
       "count": "3",
       "href": "/app/rest/users/id:16/properties",
       "property": [
          {
             "name": "buildLogConsoleStyle",
             "value": "true"
          },
          {
             "name": "visible.projects.configured",
             "value": "true"
          },
          {
             "name": "was.logged.in",
             "value": "true"
          }
       ]
    },
    "roles": [],
    "groups": {
       "count": "2",
       "group": [
          {
             "key": "ALL_USERS_GROUP",
             "name": "All Users",
             "href": "/app/rest/userGroups/key:ALL_USERS_GROUP",
             "description": "Contains all TeamCity users"
          },
          {
             "key": "BUILDMASTERS",
             "name": "Build Masters",
             "href": "/app/rest/userGroups/key:BUILDMASTERS",
             "description": "LDAP The masters of the builds"
          }
       ]
    }
}
""">

type AllProjectResponseTags = JsonProvider<""" {"count":5,"project":
[{"id":"_Root","name":"<Root project>","description":"Contains all other projects","href":"/httpAuth/app/rest/projects/id:_Root","webUrl":"http://teamcity/project.html?projectId=_Root"},
{"id":"StructuresDailyBuilds_BatTeamAdmin","name":"Admin BatTeam","parentProjectId":"_Root","href":"/httpAuth/app/rest/projects/id:StructuresDailyBuilds_BatTeamAdmin","webUrl":"http://teamcity/project.html?projectId=StructuresDailyBuilds_BatTeamAdmin"},
{"id":"BatTools","name":"Bat Tools","parentProjectId":"StructuresDailyBuilds_BatTeamAdmin","description":"Bat tools and plugins","href":"/httpAuth/app/rest/projects/id:BatTools","webUrl":"http://teamcity/project.html?projectId=BatTools"},
{"id":"BatTools_ProjectsRequiringAccessToSharedDrives","name":"Projects Requiring Access to Shared Drives","parentProjectId":"BatTools","href":"/httpAuth/app/rest/projects/id:BatTools_ProjectsRequiringAccessToSharedDrives","webUrl":"http://teamcity/project.html?projectId=BatTools_ProjectsRequiringAccessToSharedDrives"},
{"id":"TeklaWarehouse","name":"Tekla Warehouse","parentProjectId":"_Root","href":"/httpAuth/app/rest/projects/id:TeklaWarehouse","webUrl":"http://teamcity/project.html?projectId=TeklaWarehouse"}]} """>

type ProjectRespose = JsonProvider<"""{"id":"TestConfig","name":"Taf On Master","parentProjectId":"TeklaStructuresIntegrationTests_Farmi","href":"/app/rest/projects/id:TestConfig","webUrl":"http://teamcity/project.html?projectId=TestConfig","parentProject":{"id":"TeklaStructuresIntegrationTests_Farmi","name":"Taf","parentProjectId":"TeklaStructuresBuilds","href":"/app/rest/projects/id:TeklaStructuresIntegrationTests_Farmi","webUrl":"http://teamcity/project.html?projectId=TeklaStructuresIntegrationTests_Farmi"},"buildTypes":{"count":2,"buildType":[{"id":"TestConfig_RunsFarmiCasesUsingWorkBinar","name":"Runs Farmi Cases Using Work Binaries in Master","description":"ContinuousBeamReinforcement.Test.dll, DPMPrinter.Test.dll, IFCObjectConverter.IntegrationTest.dll, ProjectOrganizer.Test.dll, \\DrawingsAppsTests\\RebarLayeringMarker.Test.dll, \\Sharing.IntegrationTest.dll, \\SiteManagerTests\\SlabReinforcementTool.Test.dll, \\","projectName":"Tekla Structures :: Taf :: Taf On Master","projectId":"TestConfig","href":"/app/rest/buildTypes/id:TestConfig_RunsFarmiCasesUsingWorkBinar","webUrl":"http://teamcity/viewType.html?buildTypeId=TestConfig_RunsFarmiCasesUsingWorkBinar"},{"id":"TestConfig_FarmiSmoke","name":"Smoke Test","description":"ContinuousBeamReinforcement.Test.dll, DPMPrinter.Test.dll, IFCObjectConverter.IntegrationTest.dll, ProjectOrganizer.Test.dll, \\DrawingsAppsTests\\RebarLayeringMarker.Test.dll, \\Sharing.IntegrationTest.dll, \\SiteManagerTests\\SlabReinforcementTool.Test.dll, \\","projectName":"Tekla Structures :: Taf :: Taf On Master","projectId":"TestConfig","href":"/app/rest/buildTypes/id:TestConfig_FarmiSmoke","webUrl":"http://teamcity/viewType.html?buildTypeId=TestConfig_FarmiSmoke"}]},"templates":{"count":1,"buildType":[{"id":"TestConfig_FtcTemplate","name":"FTC Template","templateFlag":true,"projectName":"Tekla Structures :: Taf :: Taf On Master","projectId":"TestConfig","href":"/app/rest/buildTypes/id:TestConfig_FtcTemplate"}]},"parameters":{"count":2,"href":"/app/rest/projects/id:TestConfig/parameters","property":[{"name":"env.MSBUILDDISABLENODERESUSE","value":"1","inherited":true},{"name":"system.NodePath","value":"%teamcity.tool.node-v8.9.3-win-x64%\\node.exe","inherited":true}]},"vcsRoots":{"count":0,"href":"/app/rest/vcs-roots?locator=project:(id:TestConfig)"},"projectFeatures":{"count":0,"href":"/app/rest/projects/id:TestConfig/projectFeatures"},"projects":{"count":1,"project":[{"id":"TestConfig_CopyAndMove","name":"Copy and move","parentProjectId":"TestConfig","href":"/app/rest/projects/id:TestConfig_CopyAndMove","webUrl":"http://teamcity/project.html?projectId=TestConfig_CopyAndMove"}]}}""">

type ProjectResponseTags = JsonProvider<"""
{"id":"StructuresDailyBuilds_BatTeamAdmin","name":"Admin BatTeam","parentProjectId":"_Root","href":"/httpAuth/app/rest/projects/id:StructuresDailyBuilds_BatTeamAdmin","webUrl":"http://teamcity/project.html?projectId=StructuresDailyBuilds_BatTeamAdmin","parentProject":{"id":"_Root","name":"<Root project>","description":"Contains all other projects","href":"/httpAuth/app/rest/projects/id:_Root","webUrl":"http://teamcity/project.html?projectId=_Root"},
"buildTypes":{"count":1,"buildType":[{"id":"MirrorField3DIOSToStash","name":"Mirror Field3D to Stash","projectName":"Admin BatTeam","projectId":"StructuresDailyBuilds_BatTeamAdmin","href":"/httpAuth/app/rest/buildTypes/id:MirrorField3DIOSToStash","webUrl":"http://teamcity/viewType.html?buildTypeId=MirrorField3DIOSToStash"}]},"templates":{"count":0,"buildType":[]},"parameters":{"count":2,"href":"/app/rest/projects/id:StructuresDailyBuilds_BatTeamAdmin/parameters","property":[{"name":"DisableCrashLogCheck","value":"false"},{"name":"PRQ_PATH","value":"%teamcity.build.checkoutDir%\\Prerequisites\\2013\\SetupPrerequisites"}]},"vcsRoots":{"href":"/httpAuth/app/rest/vcs-roots?locator=project:(id:StructuresDailyBuilds_BatTeamAdmin)"},"projects":{"count":1,"project":[{"id":"BatTools","name":"Bat Tools","parentProjectId":"StructuresDailyBuilds_BatTeamAdmin","description":"Bat tools and plugins","href":"/httpAuth/app/rest/projects/id:BatTools","webUrl":"http://teamcity/project.html?projectId=BatTools"}]}} """>

type BuildTypeResponse = JsonProvider<"""
{"id":"BatTools_BuildAllExtension","name":"BuildAllExtension","projectName":"Admin BatTeam :: Bat Tools","projectId":"BatTools","href":"/httpAuth/app/rest/buildTypes/id:BatTools_BuildAllExtension","webUrl":"http://teamcity/viewType.html?buildTypeId=BatTools_BuildAllExtension","project":{"id":"BatTools","name":"Bat Tools","parentProjectId":"StructuresDailyBuilds_BatTeamAdmin","description":"Bat tools and plugins","href":"/httpAuth/app/rest/projects/id:BatTools","webUrl":"http://teamcity/project.html?projectId=BatTools"},"vcs-root-entries":{"vcs-root-entry":[{"id":"BatTools_VssonarExtensionGi","vcs-root":{"id":"BatTools_VssonarExtensionGi","name":"VssonarExtensionGit","href":"/httpAuth/app/rest/vcs-roots/id:BatTools_VssonarExtensionGi"},"checkout-rules":""}]},"settings":{"count":16,"property":[{"name":"allowExternalStatus","value":"false"},{"name":"artifactRules","value":"bin\\** => Release.zip"},{"name":"buildNumberCounter","value":"73"},{"name":"buildNumberPattern","value":"%build.counter%"},{"name":"checkoutDirectory"},{"name":"checkoutMode","value":"ON_SERVER"},{"name":"cleanBuild","value":"false"},{"name":"enableHangingBuildsDetection","value":"true"},{"name":"executionTimeoutMin","value":"0"},{"name":"maximumNumberOfBuilds","value":"0"},{"name":"shouldFailBuildIfTestsFailed","value":"true"},{"name":"shouldFailBuildOnAnyErrorMessage","value":"false"},{"name":"shouldFailBuildOnBadExitCode","value":"true"},{"name":"shouldFailBuildOnOOMEOrCrash","value":"true"},{"name":"showDependenciesChanges","value":"false"},{"name":"vcsLabelingBranchFilter","value":"+:<default>"}]},"parameters":{"count":6,"href":"/app/rest/buildTypes/id:BatTools_BuildAllExtension/parameters","property":[{"name":"DisableCrashLogCheck","value":"false"},{"name":"env.SONAR_RUNNER_HOME","value":"C:\\Tekla\\BuildTools\\sonar-runner","own":true},{"name":"PRQ_PATH","value":"%teamcity.build.checkoutDir%\\Prerequisites\\2013\\SetupPrerequisites"},{"name":"system.ProduceCoverage","value":"true","own":true},{"name":"system.sonar.password","value":"zxx2756fb0821b9d8c5775d03cbe80d301b"},{"name":"system.UserSRCDir","value":"%teamcity.build.checkoutDir%","type":{"rawValue":"text display='hidden'"}}]},"steps":{"count":2,"step":[{"id":"RUNNER_100","name":"BuildSolution","type":"VS.Solution","properties":{"property":[{"name":"build-file-path","value":"BuildExtension.msbuild"},{"name":"msbuild_version","value":"12.0"},{"name":"run-platform","value":"x86"},{"name":"teamcity.step.mode","value":"default"},{"name":"toolsVersion","value":"12.0"},{"name":"vs.version","value":"vs2013"}]}},{"id":"RUNNER_788","name":"","type":"RunSonarAnalysis","properties":{"property":[{"name":"env.Platform","value":"AnyCPU"},{"name":"env.SONAR_RUNNER_HOME","value":"c:\\tekla\\buildtools\\sonar-runner"},{"name":"JavaHomeToUse","value":"%teamcity.agent.home.dir%\\jre"},{"name":"PathToUse","value":"%env.SONAR_RUNNER_HOME%\\bin;%teamcity.agent.home.dir%\\jre\\bin;C:\\Program Files (x86)\\Git\\bin;%env.Path%"},{"name":"SonarDB","value":"jdbc:postgresql://sonar:5432/sonar"},{"name":"SonarHost","value":"http://sonar"},{"name":"SonarRunnerPropsToUse","value":"-Xmx1024m"},{"name":"teamcity.step.mode","value":"default"},{"name":"WorkingDirectory","value":"%teamcity.build.checkoutDir%"}]}}]},"features":{"feature":[]},"triggers":{"count":1,"trigger":[{"id":"vcsTrigger","type":"vcsTrigger","properties":{"property":[{"name":"quietPeriodMode","value":"DO_NOT_USE"}]}}]},"snapshot-dependencies":{"snapshot-dependency":[]},"artifact-dependencies":{"artifact-dependency":[]},"agent-requirements":{"count":1,"agent-requirement":[{"id":"system.agent.name","type":"contains","properties":{"property":[{"name":"property-name","value":"system.agent.name"},{"name":"property-value","value":"B-BUILDAGENT2"}]}}]},"builds":{"href":"/httpAuth/app/rest/buildTypes/id:BatTools_BuildAllExtension/builds/"}} """>

type BuildResponse = JsonProvider<"""
{"count":28,"href":"/httpAuth/app/rest/buildTypes/id:BatTools_BuildAllExtension/builds/","build":[{"id":1884284,"buildType": {
    "id": "TSChainFast_StructuresWorkBuild_TeklaStructuresX64Release",
    "name": "x64 Release",
    "projectName": "Tekla Structures :: Work - Master :: Structures Builds",
    "projectId": "TSChainFast_StructuresWorkBuild",
    "href": "/app/rest/buildTypes/id:TSChainFast_StructuresWorkBuild_TeklaStructuresX64Release",
    "webUrl": "http://teamcity/viewType.html?buildTypeId=TSChainFast_StructuresWorkBuild_TeklaStructuresX64Release"
},"comment": {
    "timestamp": "20171117T121119+0200",
    "text": "remote trigger from bitbucket server : http://stash/projects/TS/repos/structures/branches",
    "user": {
        "username": "buildmaster",
        "name": "Buildmaster",
        "id": 6,
        "href": "/app/rest/users/id:6"
    }
},"queuedDate": "20171117T121119+0200",
"startDate": "20171117T121154+0200",
"finishDate": "20171117T123602+0200","changes": {
    "href": "/app/rest/changes?locator=build:(id:11609257)"
},"agent": {
    "id": 219,
    "name": "B-BUILDAGENT53",
    "typeId": 219,
    "href": "/app/rest/agents/id:219"
}, "statusText": "asdas", "buildTypeId":"BatTools_BuildAllExtension","number":"72.354","status":"SUCCESS","state":"finished","href":"/httpAuth/app/rest/builds/id:1884284","webUrl":"http://teamcity/viewLog.html?buildId=1884284&buildTypeId=BatTools_BuildAllExtension"},{"id":1884126,"buildTypeId":"BatTools_BuildAllExtension","number":"71","status":"SUCCESS","state":"finished","href":"/httpAuth/app/rest/builds/id:1884126","webUrl":"http://teamcity/viewLog.html?buildId=1884126&buildTypeId=BatTools_BuildAllExtension"},{"id":1884121,"buildTypeId":"BatTools_BuildAllExtension","number":"70","status":"FAILURE","state":"finished","href":"/httpAuth/app/rest/builds/id:1884121","webUrl":"http://teamcity/viewLog.html?buildId=1884121&buildTypeId=BatTools_BuildAllExtension"},{"id":1883948,"buildTypeId":"BatTools_BuildAllExtension","number":"69a","status":"FAILURE","state":"finished","href":"/httpAuth/app/rest/builds/id:1883948","webUrl":"http://teamcity/viewLog.html?buildId=1883948&buildTypeId=BatTools_BuildAllExtension"},{"id":1874662,"buildTypeId":"BatTools_BuildAllExtension","number":"68a","status":"FAILURE","state":"finished","href":"/httpAuth/app/rest/builds/id:1874662","webUrl":"http://teamcity/viewLog.html?buildId=1874662&buildTypeId=BatTools_BuildAllExtension"},{"id":1874061,"buildTypeId":"BatTools_BuildAllExtension","number":"67a","status":"FAILURE","state":"finished","href":"/httpAuth/app/rest/builds/id:1874061","webUrl":"http://teamcity/viewLog.html?buildId=1874061&buildTypeId=BatTools_BuildAllExtension"},{"id":1839966,"buildTypeId":"BatTools_BuildAllExtension","number":"66a","status":"FAILURE","state":"finished","href":"/httpAuth/app/rest/builds/id:1839966","webUrl":"http://teamcity/viewLog.html?buildId=1839966&buildTypeId=BatTools_BuildAllExtension"},{"id":1839824,"buildTypeId":"BatTools_BuildAllExtension","number":"65a","status":"SUCCESS","state":"finished","href":"/httpAuth/app/rest/builds/id:1839824","webUrl":"http://teamcity/viewLog.html?buildId=1839824&buildTypeId=BatTools_BuildAllExtension"},{"id":1839802,"buildTypeId":"BatTools_BuildAllExtension","number":"64a","status":"SUCCESS","state":"finished","href":"/httpAuth/app/rest/builds/id:1839802","webUrl":"http://teamcity/viewLog.html?buildId=1839802&buildTypeId=BatTools_BuildAllExtension"},{"id":1782937,"buildTypeId":"BatTools_BuildAllExtension","number":"63a","status":"FAILURE","state":"finished","href":"/httpAuth/app/rest/builds/id:1782937","webUrl":"http://teamcity/viewLog.html?buildId=1782937&buildTypeId=BatTools_BuildAllExtension"},{"id":1782633,"buildTypeId":"BatTools_BuildAllExtension","number":"62a","status":"FAILURE","state":"finished","href":"/httpAuth/app/rest/builds/id:1782633","webUrl":"http://teamcity/viewLog.html?buildId=1782633&buildTypeId=BatTools_BuildAllExtension"},{"id":1770755,"buildTypeId":"BatTools_BuildAllExtension","number":"61a","status":"SUCCESS","state":"finished","href":"/httpAuth/app/rest/builds/id:1770755","webUrl":"http://teamcity/viewLog.html?buildId=1770755&buildTypeId=BatTools_BuildAllExtension"},{"id":1766488,"buildTypeId":"BatTools_BuildAllExtension","number":"60a","status":"SUCCESS","state":"finished","href":"/httpAuth/app/rest/builds/id:1766488","webUrl":"http://teamcity/viewLog.html?buildId=1766488&buildTypeId=BatTools_BuildAllExtension"},{"id":1765126,"buildTypeId":"BatTools_BuildAllExtension","number":"59a","status":"SUCCESS","state":"finished","href":"/httpAuth/app/rest/builds/id:1765126","webUrl":"http://teamcity/viewLog.html?buildId=1765126&buildTypeId=BatTools_BuildAllExtension"},{"id":1762928,"buildTypeId":"BatTools_BuildAllExtension","number":"58","status":"SUCCESS","state":"finished","href":"/httpAuth/app/rest/builds/id:1762928","webUrl":"http://teamcity/viewLog.html?buildId=1762928&buildTypeId=BatTools_BuildAllExtension"},{"id":1759246,"buildTypeId":"BatTools_BuildAllExtension","number":"57","status":"SUCCESS","state":"finished","href":"/httpAuth/app/rest/builds/id:1759246","webUrl":"http://teamcity/viewLog.html?buildId=1759246&buildTypeId=BatTools_BuildAllExtension"},{"id":1758293,"buildTypeId":"BatTools_BuildAllExtension","number":"56","status":"SUCCESS","state":"finished","href":"/httpAuth/app/rest/builds/id:1758293","webUrl":"http://teamcity/viewLog.html?buildId=1758293&buildTypeId=BatTools_BuildAllExtension"},{"id":1755054,"buildTypeId":"BatTools_BuildAllExtension","number":"55","status":"SUCCESS","state":"finished","href":"/httpAuth/app/rest/builds/id:1755054","webUrl":"http://teamcity/viewLog.html?buildId=1755054&buildTypeId=BatTools_BuildAllExtension"},{"id":1754574,"buildTypeId":"BatTools_BuildAllExtension","number":"54","status":"SUCCESS","state":"finished","href":"/httpAuth/app/rest/builds/id:1754574","webUrl":"http://teamcity/viewLog.html?buildId=1754574&buildTypeId=BatTools_BuildAllExtension"},{"id":1753844,"buildTypeId":"BatTools_BuildAllExtension","number":"53","status":"SUCCESS","state":"finished","href":"/httpAuth/app/rest/builds/id:1753844","webUrl":"http://teamcity/viewLog.html?buildId=1753844&buildTypeId=BatTools_BuildAllExtension"},{"id":1744475,"buildTypeId":"BatTools_BuildAllExtension","number":"52","status":"SUCCESS","state":"finished","href":"/httpAuth/app/rest/builds/id:1744475","webUrl":"http://teamcity/viewLog.html?buildId=1744475&buildTypeId=BatTools_BuildAllExtension"},{"id":1712522,"buildTypeId":"BatTools_BuildAllExtension","number":"51","status":"SUCCESS","state":"finished","href":"/httpAuth/app/rest/builds/id:1712522","webUrl":"http://teamcity/viewLog.html?buildId=1712522&buildTypeId=BatTools_BuildAllExtension"},{"id":1708392,"buildTypeId":"BatTools_BuildAllExtension","number":"50","status":"SUCCESS","state":"finished","href":"/httpAuth/app/rest/builds/id:1708392","webUrl":"http://teamcity/viewLog.html?buildId=1708392&buildTypeId=BatTools_BuildAllExtension"},{"id":1706955,"buildTypeId":"BatTools_BuildAllExtension","number":"49","status":"SUCCESS","state":"finished","href":"/httpAuth/app/rest/builds/id:1706955","webUrl":"http://teamcity/viewLog.html?buildId=1706955&buildTypeId=BatTools_BuildAllExtension"},{"id":1706275,"buildTypeId":"BatTools_BuildAllExtension","number":"48","status":"SUCCESS","state":"finished","href":"/httpAuth/app/rest/builds/id:1706275","webUrl":"http://teamcity/viewLog.html?buildId=1706275&buildTypeId=BatTools_BuildAllExtension"},{"id":1690735,"buildTypeId":"BatTools_BuildAllExtension","number":"47","status":"FAILURE","state":"finished","href":"/httpAuth/app/rest/builds/id:1690735","webUrl":"http://teamcity/viewLog.html?buildId=1690735&buildTypeId=BatTools_BuildAllExtension"},{"id":1674764,"buildTypeId":"BatTools_BuildAllExtension","number":"46","status":"FAILURE","state":"finished","href":"/httpAuth/app/rest/builds/id:1674764","webUrl":"http://teamcity/viewLog.html?buildId=1674764&buildTypeId=BatTools_BuildAllExtension"},{"id":1673575,"buildTypeId":"BatTools_BuildAllExtension","number":"45","status":"FAILURE","state":"finished","href":"/httpAuth/app/rest/builds/id:1673575","webUrl":"http://teamcity/viewLog.html?buildId=1673575&buildTypeId=BatTools_BuildAllExtension"}]} """>

type SingleBuildResponse = JsonProvider<"""
{
    "id": 20098734,
    "buildTypeId": "FTC_6211_TeklaStructuresIntegrationTestsFarmiFarmiOnMasterComponentsCustomcompo",
    "state": "queued",
    "branchName": "release/2020_Service_Pack_4",
    "href": "/httpAuth/app/rest/buildQueue/id:20098734",
    "webUrl": "http://teamcity/viewQueued.html?itemId=20098734",
    "queuedDate": "20201021T150048+0300",
    "state": "asda",
    "waitReason": "asdasda",
    "status": "asdas",
    "buildType": {
        "id": "FTC_6211_TeklaStructuresIntegrationTestsFarmiFarmiOnMasterComponentsCustomcompo",
        "name": "FTC_6211",
        "projectName": "Tekla Structures / Taf / MainVersions / Components / Custom components",
        "projectId": "TeklaStructuresIntegrationTests_Farmi_FarmiOnMaster_Components_Customcomponents",
        "href": "/httpAuth/app/rest/buildTypes/id:FTC_6211_TeklaStructuresIntegrationTestsFarmiFarmiOnMasterComponentsCustomcompo",
        "webUrl": "http://teamcity/viewType.html?buildTypeId=FTC_6211_TeklaStructuresIntegrationTestsFarmiFarmiOnMasterComponentsCustomcompo"
    },
    "comment": {
        "timestamp": "20201025T133043+0200",
        "text": "Manual - Triggered by   from: http://teamcity/viewLog.html?buildId=20093909",
        "user": {
            "username": "buildmaster",
            "name": "Buildmaster",
            "id": 6,
            "href": "/httpAuth/app/rest/users/id:6"
        }
    },
    "agent": {
        "id": 506,
        "name": "R-TAF03",
        "typeId": 390,
        "href": "/app/rest/agents/id:506",
        "webUrl": "http://teamcity/agentDetails.html?id=506&agentTypeId=390&realAgentName=R-TAF03"
    },
    "startEstimate": "20201025T161704+0200",
    "percentageComplete": "10",
    "queuedDate": "20201025T133043+0200",
    "triggered": {
        "type": "user",
        "date": "20201025T133043+0200",
        "user": {
            "username": "buildmaster",
            "name": "Buildmaster",
            "id": 6,
            "href": "/httpAuth/app/rest/users/id:6"
        }
    },
    "changes": {
        "href": "/httpAuth/app/rest/changes?locator=build:(id:20098734)"
    },
    "revisions": {
        "count": 0
    },
    "compatibleAgents": {
        "href": "/httpAuth/app/rest/agents?locator=compatible:(build:(id:20098734))"
    },
    "artifacts": {
        "href": "/httpAuth/app/rest/builds/id:20098734/artifacts/children/"
    },
    "properties": {
        "count": 26,
        "property": [
            {
                "name": "DeepCleanExclusions",
                "value": "BuildDrop Models",
                "inherited": true
            },
            {
                "name": "env.MSBUILDDISABLENODERESUSE",
                "value": "1",
                "inherited": true
            },
            {
                "name": "env.TAF_BASE_PATH",
                "value": "e:\\prod\\taf",
                "inherited": true
            }
        ]
    }
}
""">

type QueuedBuildResponse = JsonProvider<"""
{
"build": [
    {
        "id": 20048118,
        "buildTypeId": "FTC_2561_TeklaStructuresIntegrationTestsFarmiFarmiOnMasterPerformanceCore",
        "state": "queued",
        "href": "/app/rest/buildQueue/id:20048118",
        "waitReason": "asdasda",
        "branchName": "2020",
        "webUrl": "http://teamcity/viewQueued.html?itemId=20048118:0:506",
        "buildType": {
            "id": "FTC_2561_TeklaStructuresIntegrationTestsFarmiFarmiOnMasterPerformanceCore",
            "name": "FTC_2561",
            "projectName": "Tekla Structures / Taf / MainVersions / Performance / Drawings",
            "projectId": "TeklaStructuresIntegrationTests_Farmi_FarmiOnMaster_Performance_Drawings",
            "href": "/app/rest/buildTypes/id:FTC_2561_TeklaStructuresIntegrationTestsFarmiFarmiOnMasterPerformanceCore",
            "webUrl": "http://teamcity/viewType.html?buildTypeId=FTC_2561_TeklaStructuresIntegrationTestsFarmiFarmiOnMasterPerformanceCore"
        },
        "comment": {
            "timestamp": "20201022T091723+0300",
            "text": "PERF RETRIGGER: 2",
            "user": {}
        },
        "queuedDate": "20201022T091723+0300",
        "startDate": "20210114T094003+0200",
        "agent": {
            "id": 506,
            "name": "R-TAF03",
            "typeId": 390,
            "href": "/app/rest/agents/id:506",
            "webUrl": "http://teamcity/agentDetails.html?id=506&agentTypeId=390&realAgentName=R-TAF03"
        }
    },
    {
        "id": 20034869,
        "buildTypeId": "FTC_2189_TeklaStructuresIntegrationTestsFarmiFarmiOnMasterReliabilityInteropera",
        "state": "queued",
        "href": "/app/rest/buildQueue/id:20034869",
        "webUrl": "http://teamcity/viewQueued.html?itemId=20034869:0:516",
        "buildType": {
            "id": "FTC_2189_TeklaStructuresIntegrationTestsFarmiFarmiOnMasterReliabilityInteropera",
            "name": "FTC_2189",
            "projectName": "Tekla Structures / Taf / MainVersions / Reliability / Interoperability",
            "projectId": "TeklaStructuresIntegrationTests_Farmi_FarmiOnMaster_Reliability_Interoperability",
            "href": "/app/rest/buildTypes/id:FTC_2189_TeklaStructuresIntegrationTestsFarmiFarmiOnMasterReliabilityInteropera",
            "webUrl": "http://teamcity/viewType.html?buildTypeId=FTC_2189_TeklaStructuresIntegrationTestsFarmiFarmiOnMasterReliabilityInteropera"
        },
        "queuedDate": "20201021T150048+0300",
        "agent": {
            "id": 516,
            "name": "R-TAF06",
            "typeId": 400,
            "href": "/app/rest/agents/id:516",
            "webUrl": "http://teamcity/agentDetails.html?id=516&agentTypeId=400&realAgentName=R-TAF06"
        },
        "running-info": {
            "percentageComplete": 1,
            "elapsedSeconds": 2,
            "estimatedTotalSeconds": 279,
            "currentStageText": "",
            "outdated": false,
            "probablyHanging": false
        }
    },
    {
        "id": 20012607,
        "buildTypeId": "Fabsuite_Desktop_X64",
        "state": "queued",
        "href": "/app/rest/buildQueue/id:20012607",
        "webUrl": "http://teamcity/viewQueued.html?itemId=20012607",
        "buildType": {
            "id": "Fabsuite_Desktop_X64",
            "name": "Buildx64",
            "projectName": "Tekla EPM / Desktop",
            "projectId": "Fabsuite_Desktop",
            "href": "/app/rest/buildTypes/id:Fabsuite_Desktop_X64",
            "webUrl": "http://teamcity/viewType.html?buildTypeId=Fabsuite_Desktop_X64"
        },
        "queuedDate": "20201019T200740+0300"
    },
    {
        "id": 20034518,
        "buildTypeId": "FTC_20114_TeklaStructuresIntegrationTestsFarmiFarmiOnMasterComponentsCustomcomp",
        "state": "queued",
        "branchName": "<default>",
        "href": "/app/rest/buildQueue/id:20034518",
        "webUrl": "http://teamcity/viewQueued.html?itemId=20034518:0:516",
        "buildType": {
            "id": "FTC_20114_TeklaStructuresIntegrationTestsFarmiFarmiOnMasterComponentsCustomcomp",
            "name": "FTC_20114",
            "projectName": "Tekla Structures / Taf / MainVersions / Components / Custom components",
            "projectId": "TeklaStructuresIntegrationTests_Farmi_FarmiOnMaster_Components_Customcomponents",
            "href": "/app/rest/buildTypes/id:FTC_20114_TeklaStructuresIntegrationTestsFarmiFarmiOnMasterComponentsCustomcomp",
            "webUrl": "http://teamcity/viewType.html?buildTypeId=FTC_20114_TeklaStructuresIntegrationTestsFarmiFarmiOnMasterComponentsCustomcomp"
        },
        "comment": {
            "timestamp": "20201021T140201+0300",
            "text": "RETRIGGER: Schedule trigger from Taf Dashboard - Optimizing build",
            "user": {}
        },
        "queuedDate": "20201021T140201+0300",
        "agent": {
            "id": 516,
            "name": "R-TAF06",
            "typeId": 400,
            "href": "/app/rest/agents/id:516",
            "webUrl": "http://teamcity/agentDetails.html?id=516&agentTypeId=400&realAgentName=R-TAF06"
        }
    },
    {
        "id": 20048088,
        "buildTypeId": "FTC_20086_TeklaStructuresIntegrationTestsFarmiFarmiOnMasterDrawingsCloning",
        "state": "queued",
        "branchName": "<default>",
        "href": "/app/rest/buildQueue/id:20048088",
        "webUrl": "http://teamcity/viewQueued.html?itemId=20048088",
        "buildType": {
            "id": "FTC_20086_TeklaStructuresIntegrationTestsFarmiFarmiOnMasterDrawingsCloning",
            "name": "FTC_20086",
            "projectName": "Tekla Structures / Taf / MainVersions / Drawings / Cloning",
            "projectId": "TeklaStructuresIntegrationTests_Farmi_FarmiOnMaster_Drawings_Cloning",
            "href": "/app/rest/buildTypes/id:FTC_20086_TeklaStructuresIntegrationTestsFarmiFarmiOnMasterDrawingsCloning",
            "webUrl": "http://teamcity/viewType.html?buildTypeId=FTC_20086_TeklaStructuresIntegrationTestsFarmiFarmiOnMasterDrawingsCloning"
        },
        "comment": {
            "timestamp": "20201022T091511+0300",
            "text": "Schedule trigger from Taf Dashboard - Optimizing build",
            "user": {}
        },
        "startEstimate": "20201022T102342+0300",
        "queuedDate": "20201022T091511+0300"
    },
    {
        "id": 20048089,
        "buildTypeId": "FTC_8208_TeklaStructuresIntegrationTestsFarmiFarmiOnMasterDrawingsCreateOpen",
        "state": "queued",
        "branchName": "<default>",
        "href": "/app/rest/buildQueue/id:20048089",
        "webUrl": "http://teamcity/viewQueued.html?itemId=20048089",
        "buildType": {
            "id": "FTC_8208_TeklaStructuresIntegrationTestsFarmiFarmiOnMasterDrawingsCreateOpen",
            "name": "FTC_8208",
            "projectName": "Tekla Structures / Taf / MainVersions / Drawings / Create, Open",
            "projectId": "TeklaStructuresIntegrationTests_Farmi_FarmiOnMaster_Drawings_CreateOpen",
            "href": "/app/rest/buildTypes/id:FTC_8208_TeklaStructuresIntegrationTestsFarmiFarmiOnMasterDrawingsCreateOpen",
            "webUrl": "http://teamcity/viewType.html?buildTypeId=FTC_8208_TeklaStructuresIntegrationTestsFarmiFarmiOnMasterDrawingsCreateOpen"
        },
        "comment": {
            "timestamp": "20201022T091511+0300",
            "text": "Schedule trigger from Taf Dashboard - Optimizing build",
            "user": {}
        },
        "startEstimate": "20201022T102443+0300",
        "queuedDate": "20201022T091511+0300"
    },
    {
        "id": 20048090,
        "buildTypeId": "FTC_8083_TeklaStructuresIntegrationTestsFarmiFarmiOnMasterDrawingsCloning",
        "state": "queued",
        "branchName": "<default>",
        "href": "/app/rest/buildQueue/id:20048090",
        "webUrl": "http://teamcity/viewQueued.html?itemId=20048090",
        "buildType": {
            "id": "FTC_8083_TeklaStructuresIntegrationTestsFarmiFarmiOnMasterDrawingsCloning",
            "name": "FTC_8083",
            "projectName": "Tekla Structures / Taf / MainVersions / Drawings / Cloning",
            "projectId": "TeklaStructuresIntegrationTests_Farmi_FarmiOnMaster_Drawings_Cloning",
            "href": "/app/rest/buildTypes/id:FTC_8083_TeklaStructuresIntegrationTestsFarmiFarmiOnMasterDrawingsCloning",
            "webUrl": "http://teamcity/viewType.html?buildTypeId=FTC_8083_TeklaStructuresIntegrationTestsFarmiFarmiOnMasterDrawingsCloning"
        },
        "comment": {
            "timestamp": "20201022T091512+0300",
            "text": "Schedule trigger from Taf Dashboard - Optimizing build",
            "user": {}
        },
        "startEstimate": "20201022T102541+0300",
        "queuedDate": "20201022T091512+0300"
    },
    {
        "id": 20048091,
        "buildTypeId": "FTC_8204_TeklaStructuresIntegrationTestsFarmiFarmiOnMasterDrawingsDimensions",
        "state": "queued",
        "branchName": "<default>",
        "href": "/app/rest/buildQueue/id:20048091",
        "webUrl": "http://teamcity/viewQueued.html?itemId=20048091",
        "buildType": {
            "id": "FTC_8204_TeklaStructuresIntegrationTestsFarmiFarmiOnMasterDrawingsDimensions",
            "name": "FTC_8204",
            "projectName": "Tekla Structures / Taf / MainVersions / Drawings / Dimensions",
            "projectId": "TeklaStructuresIntegrationTests_Farmi_FarmiOnMaster_Drawings_Dimensions",
            "href": "/app/rest/buildTypes/id:FTC_8204_TeklaStructuresIntegrationTestsFarmiFarmiOnMasterDrawingsDimensions",
            "webUrl": "http://teamcity/viewType.html?buildTypeId=FTC_8204_TeklaStructuresIntegrationTestsFarmiFarmiOnMasterDrawingsDimensions"
        },
        "comment": {
            "timestamp": "20201022T091512+0300",
            "text": "Schedule trigger from Taf Dashboard - Optimizing build",
            "user": {}
        },
        "startEstimate": "20201022T102659+0300",
        "queuedDate": "20201022T091512+0300",
        "startDate": "20201022T091512+0300"
    },
    {
        "id": 20048092,
        "buildTypeId": "FTC_8665_TeklaStructuresIntegrationTestsFarmiFarmiOnMasterDrawingsPresentation",
        "state": "queued",
        "branchName": "<default>",
        "href": "/app/rest/buildQueue/id:20048092",
        "webUrl": "http://teamcity/viewQueued.html?itemId=20048092",
        "number": "asda",
        "status": "asdas",
        "buildType": {
            "id": "FTC_8665_TeklaStructuresIntegrationTestsFarmiFarmiOnMasterDrawingsPresentation",
            "name": "FTC_8665",
            "projectName": "Tekla Structures / Taf / MainVersions / Drawings / Presentation",
            "projectId": "TeklaStructuresIntegrationTests_Farmi_FarmiOnMaster_Drawings_Presentation",
            "href": "/app/rest/buildTypes/id:FTC_8665_TeklaStructuresIntegrationTestsFarmiFarmiOnMasterDrawingsPresentation",
            "webUrl": "http://teamcity/viewType.html?buildTypeId=FTC_8665_TeklaStructuresIntegrationTestsFarmiFarmiOnMasterDrawingsPresentation"
        },
        "comment": {
            "timestamp": "20201022T091513+0300",
            "text": "Schedule trigger from Taf Dashboard - Optimizing build",
            "user": {}
        },
        "startEstimate": "20201022T102712+0300",
        "queuedDate": "20201022T091513+0300"
    },
    {
        "id": 20048093,
        "buildTypeId": "FTC_15008_TeklaStructuresIntegrationTestsFarmiFarmiOnMasterDrawingsMarks",
        "state": "queued",
        "branchName": "<default>",
        "href": "/app/rest/buildQueue/id:20048093",
        "webUrl": "http://teamcity/viewQueued.html?itemId=20048093",
        "percentageComplete": "100",
        "number": "10asdas0",
        "buildType": {
            "id": "FTC_15008_TeklaStructuresIntegrationTestsFarmiFarmiOnMasterDrawingsMarks",
            "name": "FTC_15008",
            "projectName": "Tekla Structures / Taf / MainVersions / Drawings / Marks",
            "projectId": "TeklaStructuresIntegrationTests_Farmi_FarmiOnMaster_Drawings_Marks",
            "href": "/app/rest/buildTypes/id:FTC_15008_TeklaStructuresIntegrationTestsFarmiFarmiOnMasterDrawingsMarks",
            "webUrl": "http://teamcity/viewType.html?buildTypeId=FTC_15008_TeklaStructuresIntegrationTestsFarmiFarmiOnMasterDrawingsMarks"
        },
        "comment": {
            "timestamp": "20201022T091513+0300",
            "text": "Schedule trigger from Taf Dashboard - Optimizing build",
            "user": {}
        },
        "startEstimate": "20201022T102741+0300",
        "queuedDate": "20201022T091513+0300"
    },
    {
        "id": 20048094,
        "buildTypeId": "FTC_8971_TeklaStructuresIntegrationTestsFarmiFarmiOnMasterDrawingsViews",
        "state": "queued",
        "branchName": "<default>",
        "href": "/app/rest/buildQueue/id:20048094",
        "webUrl": "http://teamcity/viewQueued.html?itemId=20048094",
        "buildType": {
            "id": "FTC_8971_TeklaStructuresIntegrationTestsFarmiFarmiOnMasterDrawingsViews",
            "name": "FTC_8971",
            "projectName": "Tekla Structures / Taf / MainVersions / Drawings / Views",
            "projectId": "TeklaStructuresIntegrationTests_Farmi_FarmiOnMaster_Drawings_Views",
            "href": "/app/rest/buildTypes/id:FTC_8971_TeklaStructuresIntegrationTestsFarmiFarmiOnMasterDrawingsViews",
            "webUrl": "http://teamcity/viewType.html?buildTypeId=FTC_8971_TeklaStructuresIntegrationTestsFarmiFarmiOnMasterDrawingsViews"
        },
        "comment": {
            "timestamp": "20201022T091513+0300",
            "text": "Schedule trigger from Taf Dashboard - Optimizing build",
            "user": {}
        },
        "startEstimate": "20201022T102748+0300",
        "queuedDate": "20201022T091513+0300"
    },
    {
        "id": 20048095,
        "buildTypeId": "FTC_18005_TeklaStructuresIntegrationTestsFarmiFarmiOnMasterDrawingsViews",
        "state": "queued",
        "branchName": "<default>",
        "href": "/app/rest/buildQueue/id:20048095",
        "webUrl": "http://teamcity/viewQueued.html?itemId=20048095",
        "buildType": {
            "id": "FTC_18005_TeklaStructuresIntegrationTestsFarmiFarmiOnMasterDrawingsViews",
            "name": "FTC_18005",
            "projectName": "Tekla Structures / Taf / MainVersions / Drawings / Views",
            "projectId": "TeklaStructuresIntegrationTests_Farmi_FarmiOnMaster_Drawings_Views",
            "href": "/app/rest/buildTypes/id:FTC_18005_TeklaStructuresIntegrationTestsFarmiFarmiOnMasterDrawingsViews",
            "webUrl": "http://teamcity/viewType.html?buildTypeId=FTC_18005_TeklaStructuresIntegrationTestsFarmiFarmiOnMasterDrawingsViews"
        },
        "comment": {
            "timestamp": "20201022T091515+0300",
            "text": "Schedule trigger from Taf Dashboard - Optimizing build",
            "user": {}
        },
        "startEstimate": "20201022T102952+0300",
        "queuedDate": "20201022T091515+0300"
    },
    {
        "id": 20048098,
        "buildTypeId": "FTC_80_TeklaStructuresIntegrationTestsFarmiFarmiOnMasterDrawingsLayoutTemplates",
        "state": "queued",
        "branchName": "<default>",
        "href": "/app/rest/buildQueue/id:20048098",
        "webUrl": "http://teamcity/viewQueued.html?itemId=20048098",
        "buildType": {
            "id": "FTC_80_TeklaStructuresIntegrationTestsFarmiFarmiOnMasterDrawingsLayoutTemplates",
            "name": "FTC_80",
            "projectName": "Tekla Structures / Taf / MainVersions / Drawings / Layout / Templates",
            "projectId": "TeklaStructuresIntegrationTests_Farmi_FarmiOnMaster_Drawings_LayoutTemplates",
            "href": "/app/rest/buildTypes/id:FTC_80_TeklaStructuresIntegrationTestsFarmiFarmiOnMasterDrawingsLayoutTemplates",
            "webUrl": "http://teamcity/viewType.html?buildTypeId=FTC_80_TeklaStructuresIntegrationTestsFarmiFarmiOnMasterDrawingsLayoutTemplates"
        },
        "comment": {
            "timestamp": "20201022T091515+0300",
            "text": "Schedule trigger from Taf Dashboard - Optimizing build",
            "user": {}
        },
        "startEstimate": "20201022T103029+0300",
        "queuedDate": "20201022T091515+0300"
    },
    {
        "id": 20048117,
        "buildTypeId": "FTC_8556_TeklaStructuresIntegrationTestsFarmiFarmiOnMasterDrawingsPresentation",
        "state": "queued",
        "branchName": "<default>",
        "href": "/app/rest/buildQueue/id:20048117",
        "webUrl": "http://teamcity/viewQueued.html?itemId=20048117:0:490",
        "buildType": {
            "id": "FTC_8556_TeklaStructuresIntegrationTestsFarmiFarmiOnMasterDrawingsPresentation",
            "name": "FTC_8556",
            "projectName": "Tekla Structures / Taf / MainVersions / Drawings / Presentation",
            "projectId": "TeklaStructuresIntegrationTests_Farmi_FarmiOnMaster_Drawings_Presentation",
            "href": "/app/rest/buildTypes/id:FTC_8556_TeklaStructuresIntegrationTestsFarmiFarmiOnMasterDrawingsPresentation",
            "webUrl": "http://teamcity/viewType.html?buildTypeId=FTC_8556_TeklaStructuresIntegrationTestsFarmiFarmiOnMasterDrawingsPresentation"
        },
        "comment": {
            "timestamp": "20201022T091702+0300",
            "text": "Triggered from: http://teamcity/viewLog.html?buildId=20047505",
            "user": {}
        },
        "startEstimate": "20201022T105333+0300",
        "queuedDate": "20201022T091702+0300",
        "agent": {
            "id": 490,
            "name": "ESX-NUNIT27",
            "typeId": 374,
            "href": "/app/rest/agents/id:490",
            "webUrl": "http://teamcity/agentDetails.html?id=490&agentTypeId=374&realAgentName=ESX-NUNIT27"
        }
    }
]
}
""">

type TriggerBuildResponse = XmlProvider<""" 
<build id="9592904"
       buildTypeId="StructuresOfficial_MakeReleaseTest_MakeReleaseReset" state="queued" branchName="master" href="/app/rest/buildQueue/id:9592904" webUrl="http://teamcity/viewQueued.html?itemId=9592904">
<buildType id="StructuresOfficial_MakeReleaseTest_MakeReleaseReset" name="MakeRelease" description="Builds TS with the official relase build settings" projectName="Tekla Structures :: MakeRelease Daily" projectId="StructuresOfficial_MakeReleaseTest" href="/app/rest/buildTypes/id:StructuresOfficial_MakeReleaseTest_MakeReleaseReset" webUrl="http://teamcity/viewType.html?buildTypeId=StructuresOfficial_MakeReleaseTest_MakeReleaseReset"/>
<comment>
<user username="jocs" name="Costa Jorge" id="5" href="/app/rest/users/id:5"/>
<timestamp>20150708T232252+0300</timestamp>
<text>trigger a failed build</text>
</comment>
<queuedDate>20150708T232252+0300</queuedDate>
<triggered type="user" date="20150708T232252+0300">
<user username="jocs" name="Costa Jorge" id="5" href="/app/rest/users/id:5"/>
</triggered>
<changes href="/app/rest/changes?locator=build:(id:9592904)"/>
<revisions count="0"/>
<compatibleAgents href="/app/rest/buildQueue/id:9592904/compatibleAgents"/>
<properties count="11">
<property name="DisableCrashLogCheck" value="false"/>
<property name="InstallShieldEXE" value="C:\Program Files (x86)\InstallShield\2014 SAB\System\iscmdbld.exe"/>
<property name="PRQ_PATH" value="%teamcity.build.checkoutDir%\Prerequisites\2014\SetupPrerequisites"/>
<property name="system.BRANCH" value="%teamcity.build.branch%"/>
<property name="system.DeveloperFlags" value=""/>
<property name="system.DIST_BUILD_NUMBER" value="%build.counter%"/>
<property name="system.OfficialBuildFlag" value="OFFICIAL_BUILD"/>
<property name="system.RELEASE_VERSION" value="Next Test" own="true"/>
<property name="system.RELEASE_VERSION_TEXT" value="%teamcity.build.branch%"/>
<property name="system.TSVersion" value="%teamcity.build.branch%"/>
<property name="system.version_revision_date_text" value="1970-01-01"/>
</properties>
<attributes count="1"><entry name="teamcity.cleanSources" value="true"/>
</attributes>
</build> """>


type TestDetails = JsonProvider<"""
{
    "id": "id:9797,build:(id:12676325)",
    "name": "FTC_2726.EmptyModel",
    "status": "FAILURE",
    "duration": 337446,
    "currentlyInvestigated": true,
    "currentlyMuted": true,
    "muted": true,
    "href": "/app/rest/testOccurrences/id:9797,build:(id:12676325)",
    "details": "Failed\nThe following error messages were found : \r\n Some macro has failed to run, see log and investigate why macro is failing\r\nhttp:/b-farmiweb/cgi-bin/farmi.cgi?app=latest&version=work-x64&ftc=2726",
    "test": {
        "id": "2320430423131597177",
        "name": "FTC_2726.EmptyModel",
        "href": "/app/rest/tests/id:2320430423131597177"
    },
    "build": {
        "id": 12676325,
        "buildTypeId": "FTC_2726_TeklaStructuresIntegrationTestsFarmiFarmiOnMasterMultiuseModelSharing",
        "number": "124",
        "status": "FAILURE",
        "state": "finished",
        "branchName": "master",
        "defaultBranch": true,
        "href": "/app/rest/builds/id:12676325",
        "webUrl": "http://teamcity/viewLog.html?buildId=12676325&buildTypeId=FTC_2726_TeklaStructuresIntegrationTestsFarmiFarmiOnMasterMultiuseModelSharing"
    },
    "firstFailed": {
        "id": "id:15682,build:(id:12675830)",
        "name": "FTC_2726.EmptyModel",
        "status": "FAILURE",
        "duration": 332912,
        "currentlyInvestigated": true,
        "href": "/app/rest/testOccurrences/id:15682,build:(id:12675830)"
    }
}
""">

type TestResponse = JsonProvider<"""
{
    "count": 1,
    "href": "http://teamcity/app/rest/testOccurrences?locator=build:id:12632785",
    "testOccurrence": [
        {
            "id": "id:15509,build:(id:12632785)",
            "name": "FTC_5309.DiagnoseAndRepairNumbering_170_enu_default",
            "status": "FAILURE",
            "duration": 40078,
            "muted": true,
            "currentlyMuted": true,
            "currentlyInvestigated": true,
            "href": "/app/rest/testOccurrences/id:15509,build:(id:12632785)"
        },
        {
            "id": "id:15509,build:(id:12632785)",
            "name": "FTC_5309.DiagnoseAndRepairNumbering_170_enu_default",
            "status": "FAILURE",
            "href": "/app/rest/testOccurrences/id:15509,build:(id:12632785)"
        }
    ],
    "default": false
}
""">

type UniqueBuildResponse = JsonProvider<"""
{
    "id": "11609257A",
    "buildTypeId": "TSChainFast_StructuresWorkBuild_TeklaStructuresX64Release",
    "number": "35189a",
    "status": "SUCCESS",
    "state": "finished",
    "branchName": "master",
    "defaultBranch": true,
    "href": "/app/rest/builds/id:11609257",
    "webUrl": "http://teamcity/viewLog.html?buildId=11609257&buildTypeId=TSChainFast_StructuresWorkBuild_TeklaStructuresX64Release",
    "statusText": "Tests passed: 4558, ignored: 63, muted: 2",
    "buildType": {
        "id": "TSChainFast_StructuresWorkBuild_TeklaStructuresX64Release",
        "name": "x64 Release",
        "projectName": "Tekla Structures :: Work - Master :: Structures Builds",
        "projectId": "TSChainFast_StructuresWorkBuild",
        "href": "/app/rest/buildTypes/id:TSChainFast_StructuresWorkBuild_TeklaStructuresX64Release",
        "webUrl": "http://teamcity/viewType.html?buildTypeId=TSChainFast_StructuresWorkBuild_TeklaStructuresX64Release"
    },
    "comment": {
        "timestamp": "20171117T121119+0200",
        "text": "remote trigger from bitbucket server : http://stash/projects/TS/repos/structures/branches",
        "user": {
            "username": "buildmaster",
            "name": "Buildmaster",
            "id": 6,
            "href": "/app/rest/users/id:6"
        }
    },
    "queuedDate": "20171117T121119+0200",
    "startDate": "20171117T121154+0200",
    "finishDate": "20171117T123602+0200",
    "triggered": {
        "type": "user",
        "date": "20171117T121119+0200",
        "user": {
            "username": "buildmaster",
            "name": "Buildmaster",
            "id": 6,
            "href": "/app/rest/users/id:6"
        },
        "build": {
            "id": 14102314,
            "buildTypeId": "Win32x64Features_TeklaStructuresX64Release",
            "number": "54480",
            "status": "FAILURE",
            "state": "finished",
            "branchName": "feature/TTSD-24520_move-tracking-interface-to-commonmin",
            "href": "/app/rest/builds/id:14102314",
            "webUrl": "http://teamcity/viewLog.html?buildId=14102314&buildTypeId=Win32x64Features_TeklaStructuresX64Release"
        },
        "buildType": {
            "id": "Win32x64Features_TeklaStructuresX64Release",
            "name": "x64 Release",
            "projectName": "Tekla Structures / DailyBuilds / Structures Feature Branches",
            "projectId": "TSChainFast_StructuresWorkBuild_Win32x64Features",
            "href": "/app/rest/buildTypes/id:Win32x64Features_TeklaStructuresX64Release",
            "webUrl": "http://teamcity/viewType.html?buildTypeId=Win32x64Features_TeklaStructuresX64Release"
        }
    },
    "lastChanges": {
        "count": 1,
        "change": [
            {
                "id": 2213929,
                "version": "9cf121f056e28bca9d216cb6b4a596a0ae380800",
                "username": "lavonen jukka",
                "date": "20171117T121120+0200",
                "href": "/app/rest/changes/id:2213929",
                "webUrl": "http://teamcity/viewModification.html?modId=2213929&personal=false"
            }
        ]
    },
    "changes": {
        "href": "/app/rest/changes?locator=build:(id:11609257)"
    },
    "revisions": {
        "count": 1,
        "revision": [
            {
                "version": "9cf121f056e28bca9d216cb6b4a596a0ae380800",
                "vcsBranchName": "refs/heads/master",
                "vcs-root-instance": {
                    "id": "3067",
                    "vcs-root-id": "StructuresWork",
                    "name": "structuresWork",
                    "href": "/app/rest/vcs-root-instances/id:3067"
                }
            }
        ]
    },
    "agent": {
        "id": 219,
        "name": "B-BUILDAGENT53",
        "typeId": 219,
        "href": "/app/rest/agents/id:219"
    },
    "problemOccurrences": {
        "count": 2,
        "href" : "/app/rest/ProblemOccurrences?locator=build:(id:11609257)"
    },
    "testOccurrences": {
        "count": 4623,
        "href": "/app/rest/testOccurrences?locator=build:(id:11609257)",
        "default": false,
        "passed": 4558,
        "ignored": 63,
        "muted": 2
    },
    "artifacts": {
        "href": "/app/rest/builds/id:11609257/artifacts/children/"
    },
    "relatedIssues": {
        "href": "/app/rest/builds/id:11609257/relatedIssues"
    },
    "properties": {
        "count": 25,
        "property": [
            {
                "name": "ActualBinDirectory",
                "value": "bin_release_x64",
                "inherited": true
            },
            {
                "name": "ActualBinDirectory",
                "value": "bin_release_x64"
            }
        ]
    },
    "statistics": {
        "href": "/app/rest/builds/id:11609257/statistics"
    },
    "artifact-dependencies": {
        "count": 6,
        "build": [
            {
                "id": 11609148,
                "buildTypeId": "TSChainFast_TsCommonFast_OpenAPIDocumentation",
                "number": "6063a",
                "status": "SUCCESS",
                "state": "finished",
                "branchName": "master",
                "defaultBranch": true,
                "href": "/app/rest/builds/id:11609148",
                "webUrl": "http://teamcity/viewLog.html?buildId=11609148&buildTypeId=TSChainFast_TsCommonFast_OpenAPIDocumentation"
            }
        ]
    }
} """>

type BuildTypeResponseProjectRecursive = JsonProvider<"""{"count":15,"href":"/app/rest/buildTypes?locator=affectedProject:%28id:TeklaStructuresIntegrationTests_Farmi_PullRequests_AnalysisandDesign_Analysisan%29","buildType":[{"id":"FTC_122_TeklaStructuresIntegrationTestsFarmiPullRequestsAnalysisandDesignAnalys","name":"FTC_122","projectName":"Tekla Structures / Taf / Pull requests / Analysis and Design / Analysis and Design","projectId":"TeklaStructuresIntegrationTests_Farmi_PullRequests_AnalysisandDesign_Analysisan","href":"/app/rest/buildTypes/id:FTC_122_TeklaStructuresIntegrationTestsFarmiPullRequestsAnalysisandDesignAnalys","webUrl":"http://teamcity/viewType.html?buildTypeId=FTC_122_TeklaStructuresIntegrationTestsFarmiPullRequestsAnalysisandDesignAnalys"},{"id":"FTC_13_TeklaStructuresIntegrationTestsFarmiPullRequestsAnalysisandDesignAnalysi","name":"FTC_13","projectName":"Tekla Structures / Taf / Pull requests / Analysis and Design / Analysis and Design","projectId":"TeklaStructuresIntegrationTests_Farmi_PullRequests_AnalysisandDesign_Analysisan","href":"/app/rest/buildTypes/id:FTC_13_TeklaStructuresIntegrationTestsFarmiPullRequestsAnalysisandDesignAnalysi","webUrl":"http://teamcity/viewType.html?buildTypeId=FTC_13_TeklaStructuresIntegrationTestsFarmiPullRequestsAnalysisandDesignAnalysi"},{"id":"FTC_20004_TeklaStructuresIntegrationTestsFarmiPullRequestsAnalysisandDesignAnal","name":"FTC_20004","projectName":"Tekla Structures / Taf / Pull requests / Analysis and Design / Analysis and Design","projectId":"TeklaStructuresIntegrationTests_Farmi_PullRequests_AnalysisandDesign_Analysisan","href":"/app/rest/buildTypes/id:FTC_20004_TeklaStructuresIntegrationTestsFarmiPullRequestsAnalysisandDesignAnal","webUrl":"http://teamcity/viewType.html?buildTypeId=FTC_20004_TeklaStructuresIntegrationTestsFarmiPullRequestsAnalysisandDesignAnal"},{"id":"FTC_20007_TeklaStructuresIntegrationTestsFarmiPullRequestsAnalysisandDesignAnal","name":"FTC_20007","projectName":"Tekla Structures / Taf / Pull requests / Analysis and Design / Analysis and Design","projectId":"TeklaStructuresIntegrationTests_Farmi_PullRequests_AnalysisandDesign_Analysisan","href":"/app/rest/buildTypes/id:FTC_20007_TeklaStructuresIntegrationTestsFarmiPullRequestsAnalysisandDesignAnal","webUrl":"http://teamcity/viewType.html?buildTypeId=FTC_20007_TeklaStructuresIntegrationTestsFarmiPullRequestsAnalysisandDesignAnal"},{"id":"FTC_20012_TeklaStructuresIntegrationTestsFarmiPullRequestsAnalysisandDesignAnal","name":"FTC_20012","projectName":"Tekla Structures / Taf / Pull requests / Analysis and Design / Analysis and Design","projectId":"TeklaStructuresIntegrationTests_Farmi_PullRequests_AnalysisandDesign_Analysisan","href":"/app/rest/buildTypes/id:FTC_20012_TeklaStructuresIntegrationTestsFarmiPullRequestsAnalysisandDesignAnal","webUrl":"http://teamcity/viewType.html?buildTypeId=FTC_20012_TeklaStructuresIntegrationTestsFarmiPullRequestsAnalysisandDesignAnal"},{"id":"FTC_20020_TeklaStructuresIntegrationTestsFarmiPullRequestsAnalysisandDesignAnal","name":"FTC_20020","projectName":"Tekla Structures / Taf / Pull requests / Analysis and Design / Analysis and Design","projectId":"TeklaStructuresIntegrationTests_Farmi_PullRequests_AnalysisandDesign_Analysisan","href":"/app/rest/buildTypes/id:FTC_20020_TeklaStructuresIntegrationTestsFarmiPullRequestsAnalysisandDesignAnal","webUrl":"http://teamcity/viewType.html?buildTypeId=FTC_20020_TeklaStructuresIntegrationTestsFarmiPullRequestsAnalysisandDesignAnal"},{"id":"FTC_20027_TeklaStructuresIntegrationTestsFarmiPullRequestsAnalysisandDesignAnal","name":"FTC_20027","projectName":"Tekla Structures / Taf / Pull requests / Analysis and Design / Analysis and Design","projectId":"TeklaStructuresIntegrationTests_Farmi_PullRequests_AnalysisandDesign_Analysisan","href":"/app/rest/buildTypes/id:FTC_20027_TeklaStructuresIntegrationTestsFarmiPullRequestsAnalysisandDesignAnal","webUrl":"http://teamcity/viewType.html?buildTypeId=FTC_20027_TeklaStructuresIntegrationTestsFarmiPullRequestsAnalysisandDesignAnal"},{"id":"FTC_20072_TeklaStructuresIntegrationTestsFarmiPullRequestsAnalysisandDesignAnal","name":"FTC_20072","projectName":"Tekla Structures / Taf / Pull requests / Analysis and Design / Analysis and Design","projectId":"TeklaStructuresIntegrationTests_Farmi_PullRequests_AnalysisandDesign_Analysisan","href":"/app/rest/buildTypes/id:FTC_20072_TeklaStructuresIntegrationTestsFarmiPullRequestsAnalysisandDesignAnal","webUrl":"http://teamcity/viewType.html?buildTypeId=FTC_20072_TeklaStructuresIntegrationTestsFarmiPullRequestsAnalysisandDesignAnal"},{"id":"FTC_20199_TeklaStructuresIntegrationTestsFarmiPullRequestsAnalysisandDesignAnal","name":"FTC_20199","projectName":"Tekla Structures / Taf / Pull requests / Analysis and Design / Analysis and Design","projectId":"TeklaStructuresIntegrationTests_Farmi_PullRequests_AnalysisandDesign_Analysisan","href":"/app/rest/buildTypes/id:FTC_20199_TeklaStructuresIntegrationTestsFarmiPullRequestsAnalysisandDesignAnal","webUrl":"http://teamcity/viewType.html?buildTypeId=FTC_20199_TeklaStructuresIntegrationTestsFarmiPullRequestsAnalysisandDesignAnal"},{"id":"FTC_3701_TeklaStructuresIntegrationTestsFarmiPullRequestsAnalysisandDesignAnaly","name":"FTC_3701","projectName":"Tekla Structures / Taf / Pull requests / Analysis and Design / Analysis and Design","projectId":"TeklaStructuresIntegrationTests_Farmi_PullRequests_AnalysisandDesign_Analysisan","href":"/app/rest/buildTypes/id:FTC_3701_TeklaStructuresIntegrationTestsFarmiPullRequestsAnalysisandDesignAnaly","webUrl":"http://teamcity/viewType.html?buildTypeId=FTC_3701_TeklaStructuresIntegrationTestsFarmiPullRequestsAnalysisandDesignAnaly"},{"id":"FTC_70_TeklaStructuresIntegrationTestsFarmiPullRequestsAnalysisandDesignAnalysi","name":"FTC_70","projectName":"Tekla Structures / Taf / Pull requests / Analysis and Design / Analysis and Design","projectId":"TeklaStructuresIntegrationTests_Farmi_PullRequests_AnalysisandDesign_Analysisan","href":"/app/rest/buildTypes/id:FTC_70_TeklaStructuresIntegrationTestsFarmiPullRequestsAnalysisandDesignAnalysi","webUrl":"http://teamcity/viewType.html?buildTypeId=FTC_70_TeklaStructuresIntegrationTestsFarmiPullRequestsAnalysisandDesignAnalysi"},{"id":"FTC_71_TeklaStructuresIntegrationTestsFarmiPullRequestsAnalysisandDesignAnalysi","name":"FTC_71","projectName":"Tekla Structures / Taf / Pull requests / Analysis and Design / Analysis and Design","projectId":"TeklaStructuresIntegrationTests_Farmi_PullRequests_AnalysisandDesign_Analysisan","href":"/app/rest/buildTypes/id:FTC_71_TeklaStructuresIntegrationTestsFarmiPullRequestsAnalysisandDesignAnalysi","webUrl":"http://teamcity/viewType.html?buildTypeId=FTC_71_TeklaStructuresIntegrationTestsFarmiPullRequestsAnalysisandDesignAnalysi"},{"id":"NUNIT_13_TeklaStructuresIntegrationTestsFarmiPullRequestsAnalysisandDesignAnaly","name":"NUNIT_13","projectName":"Tekla Structures / Taf / Pull requests / Analysis and Design / Analysis and Design","projectId":"TeklaStructuresIntegrationTests_Farmi_PullRequests_AnalysisandDesign_Analysisan","href":"/app/rest/buildTypes/id:NUNIT_13_TeklaStructuresIntegrationTestsFarmiPullRequestsAnalysisandDesignAnaly","webUrl":"http://teamcity/viewType.html?buildTypeId=NUNIT_13_TeklaStructuresIntegrationTestsFarmiPullRequestsAnalysisandDesignAnaly"},{"id":"NUNIT_70_TeklaStructuresIntegrationTestsFarmiPullRequestsAnalysisandDesignAnaly","name":"NUNIT_70","projectName":"Tekla Structures / Taf / Pull requests / Analysis and Design / Analysis and Design","projectId":"TeklaStructuresIntegrationTests_Farmi_PullRequests_AnalysisandDesign_Analysisan","href":"/app/rest/buildTypes/id:NUNIT_70_TeklaStructuresIntegrationTestsFarmiPullRequestsAnalysisandDesignAnaly","webUrl":"http://teamcity/viewType.html?buildTypeId=NUNIT_70_TeklaStructuresIntegrationTestsFarmiPullRequestsAnalysisandDesignAnaly"},{"id":"NUNIT_71_TeklaStructuresIntegrationTestsFarmiPullRequestsAnalysisandDesignAnaly","name":"NUNIT_71","projectName":"Tekla Structures / Taf / Pull requests / Analysis and Design / Analysis and Design","projectId":"TeklaStructuresIntegrationTests_Farmi_PullRequests_AnalysisandDesign_Analysisan","href":"/app/rest/buildTypes/id:NUNIT_71_TeklaStructuresIntegrationTestsFarmiPullRequestsAnalysisandDesignAnaly","webUrl":"http://teamcity/viewType.html?buildTypeId=NUNIT_71_TeklaStructuresIntegrationTestsFarmiPullRequestsAnalysisandDesignAnaly"}]}""">

type ChangeUnique = JsonProvider<"""
{
    "id": 2213929,
    "version": "9cf121f056e28bca9d216cb6b4a596a0ae380800",
    "username": "lavonen jukka",
    "date": "20171117T121120+0200",
    "href": "/app/rest/changes/id:2213929",
    "webUrl": "http://teamcity/viewModification.html?modId=2213929&personal=false",
    "comment": "sasdasads",
    "files": {
        "count": 0,
        "file": []
    },
    "vcsRootInstance": {
        "id": "3067",
        "vcs-root-id": "StructuresWork",
        "name": "structuresWork",
        "href": "/app/rest/vcs-root-instances/id:3067"
    }
}""">

type ProblemOccurancesResponse = JsonProvider<"""
{
    "count": 3,
    "href": "http://teamcity/app/rest/problemOccurrences?locator=build:(id:15548352)",
    "problemOccurrence": [
            {
               "id": "problem:(id:155856),build:(id:15548352)",
               "type": "TCCOMPILATIONERROR",
               "identity": "Drawings\\Plugins\\COG-412572352",
               "href": "/app/rest/problemOccurrences/problem:(id:155856),build:(id:15548352)"
            },
            {
               "id": "problem:(id:46752),build:(id:15548352)",
               "type": "TCCOMPILATIONERROR",
               "identity": "Drawings\\Application510121865",
               "href": "/app/rest/problemOccurrences/problem:(id:46752),build:(id:15548352)"
            },
            {
               "id": "problem:(id:149302),build:(id:15548352)",
               "type": "TCEXITCODE",
               "identity": "VS.SolutionRUNNER1481",
               "href": "/app/rest/problemOccurrences/problem:(id:149302),build:(id:15548352)"
            }
         ]
}""">

type ProblemOccurancesDetailsResponse = JsonProvider<"""
{
    "id":"problem:(id:155856),build:(id:15548352)",
    "type":"TC_COMPILATION_ERROR",
    "identity":"Drawings\\Plugins\\COG_-412572352",
    "href":"/app/rest/problemOccurrences/problem:(id:155856),build:(id:15548352)",
    "details":"Compilation error: Drawings\\Plugins\\COGDimensioning\\COGDimensioning.csproj",
    "additionalData":"compileBlockId='786'",
    "problem": {
        "id":"155856",
        "type":"TC_COMPILATION_ERROR",
        "identity":"Drawings\\Plugins\\COG_-412572352",
        "href":"/app/rest/problems/id:155856"
     },
     "build": {
        "id":"15548352",
        "buildTypeId":"TeklaStructuresExternalComponents_XITing_XITingPluginsReleaseMasterLatestNuGets",
        "number":"131",
        "status":"FAILURE",
        "state":"finished",
        "branchName":"master",
        "defaultBranch":"true",
        "href":"/app/rest/builds/id:15548352",
        "webUrl":"http://teamcity/viewLog.html?buildId=15548352&buildTypeId=TeklaStructuresExternalComponents_XITing_XITingPluginsReleaseMasterLatestNuGets"
    }
}""">


type Changes = JsonProvider<"""
{
    "count": 2,
    "change": [
        {
            "id": 2776374,
            "version": "dd1b7a9a2d92b3635a90c0f7df34f7bb28b4c0e4",
            "username": "tran tu",
            "date": "20180820T074849+0300",
            "href": "/app/rest/changes/id:2776374",
            "webUrl": "http://teamcity/viewModification.html?modId=2776374&personal=false"
        },
        {
            "id": 2776373,
            "version": "49763d8e81aafcc3cda5051defd1ced385f87711",
            "username": "lauri kosonen",
            "date": "20180817T154631+0300",
            "href": "/app/rest/changes/id:2776373",
            "webUrl": "http://teamcity/viewModification.html?modId=2776373&personal=false"
        }
    ],
    "href": "/app/rest/changes?locator=build:%28id:12519813%29"
}
""">

type TestMetaData = JsonProvider<"""
{
    "metadata": {
        "count": 31,
        "typedValues": [
            {
                "name": "FTC_2553-TeklaStructures.exe-Start-Perf-TeklaStructures-CpuUsage",
                "type": "number",
                "value": "7.406968"
            },
            {
                "name": "FTC_2553-TeklaStructures.exe-Start-Perf-TeklaStructures-CpuUsage-MONTH-CHANGE-PERCENTAGE",
                "type": "number",
                "value": "0.0"
            },
            {
                "name": "FTC_2553-TeklaStructures.exe-Start-Perf-TeklaStructures-CpuUsage-MONTH-TREND",
                "type": "text",
                "value": "NOTAVAILABLE"
            },
            {
                "name": "FTC_2553-TeklaStructures.exe-Start-Perf-TeklaStructures-CpuUsage-WEEK-CHANGE-PERCENTAGE",
                "type": "number",
                "value": "0.0"
            },
            {
                "name": "FTC_2553-TeklaStructures.exe-Start-Perf-TeklaStructures-CpuUsage-WEEK-TREND",
                "type": "text",
                "value": "SAME"
            },
            {
                "name": "FTC_2553-TeklaStructures.exe-Start-Perf-TeklaStructures-CpuUsage-YEAR-CHANGE-PERCENTAGE",
                "type": "number",
                "value": "0.0"
            },
            {
                "name": "teamcity.auto.name:1",
                "type": "image",
                "value": "FTC_2553-TeklaStructures.exe-Start-Perf-TeklaStructures_perf_package.zip!/FTC_2553-TeklaStructures.exe-Start-Perf-TeklaStructures-history-execution-time.png"
            },
            {
                "name": "teamcity.auto.name:7",
                "type": "artifact",
                "value": "FTC_2553-TeklaStructures.exe-Start-Perf-TeklaStructures_perf_package.zip!/FTC_2553-TeklaStructures.exe-Start-Perf-TeklaStructures-performance-total-interpolated.png"
            },
            {
                "name": "teamcity.auto.name:8",
                "type": "image",
                "value": "FTC_2553-TeklaStructures.exe-Start-Perf-TeklaStructures_perf_package.zip!/FTC_2553-TeklaStructures.exe-Start-Perf-TeklaStructures-performance-total.png"
            },
            {
                "name": "teamcity.auto.name:9",
                "type": "artifact",
                "value": "FTC_2553-TeklaStructures.exe-Start-Perf-TeklaStructures_perf_package.zip!/FTC_2553-TeklaStructures.exe-Start-Perf-TeklaStructures-performance-total.png"
            }
        ],
        "default": false
    }
}
""">
type TestDetailsJson = JsonProvider<"""{"id":"id:503,build:(id:14783632)","name":"FTC_2728.EmptyModel","status":"FAILURE","duration":123466,"muted":true,"currentlyMuted":true,"currentlyInvestigated":true,"href":"/app/rest/testOccurrences/id:503,build:(id:14783632)","details":"Test Generated Incorrect References, Check Diff Report\nThe following error messages were found : \r\n \r\n\r\n\r\n\r\nFTC_2728.EmptyModel Asserts in teklastructures/libapplication/appl_user_model_role.cpp:248 with Message: Could not retrieve current user or model guid\r\nFTC_2728.EmptyModel Asserts in teklastructures/libapplication/appl_user_model_role.cpp:248 with Message: Could not retrieve current user or model guid\r\n See Teamcity artifacts to evalute the generated diff. Build => Artifacts section.","test":{"id":"3917745388714076008","name":"FTC_2728.EmptyModel","href":"/app/rest/tests/id:3917745388714076008"},"mute":{"id":6803,"href":"/app/rest/mutes/id:6803","assignment":{"timestamp":"20190614T140526+0300","text":"TTSD-26111","user":{"username":"jocs","name":"Costa Jorge","id":5,"href":"/app/rest/users/id:5"}},"scope":{"project":{"id":"TeklaStructuresIntegrationTests_Farmi","name":"Taf","parentProjectId":"TeklaStructuresBuilds","href":"/app/rest/projects/id:TeklaStructuresIntegrationTests_Farmi","webUrl":"http://teamcity/project.html?projectId=TeklaStructuresIntegrationTests_Farmi"}},"target":{"tests":{"count":1,"default":false,"test":[{"id":"3917745388714076008","name":"FTC_2728.EmptyModel","href":"/app/rest/tests/id:3917745388714076008"}]}},"resolution":{"type":"whenFixed"}},"build":{"id":14783632,"buildTypeId":"FTC_2728_TeklaStructuresIntegrationTestsFarmiFarmiOnMasterMultiuseModelSharing","number":"803","status":"SUCCESS","state":"finished","branchName":"master","defaultBranch":true,"href":"/app/rest/builds/id:14783632","webUrl":"http://teamcity/viewLog.html?buildId=14783632&buildTypeId=FTC_2728_TeklaStructuresIntegrationTestsFarmiFarmiOnMasterMultiuseModelSharing"},"firstFailed":{"id":"id:484,build:(id:14770049)","name":"FTC_2728.EmptyModel","status":"FAILURE","duration":122905,"muted":true,"currentlyMuted":true,"currentlyInvestigated":true,"href":"/app/rest/testOccurrences/id:484,build:(id:14770049)"}}""">
type TestMuteDetailsJson = JsonProvider<"""
{
    "id": "-351385894798633138",
    "name": "Work-TAF: NUNIT_59.RebarCatalog_WPF_NunitFusionTestModel",
    "mutes": {
        "count": 1,
        "default": false,
        "mute": [
            {
                "id": 8402,
                "href": "/app/rest/mutes/id:8402",
                "assignment": {
                    "timestamp": "20191217T033420+0200",
                    "text": "[TTSD-32581],",
                    "user": {
                        "username": "jocs",
                        "name": "Costa Jorge",
                        "id": 5,
                        "href": "/app/rest/users/id:5"
                    }
                },
                "scope": {
                    "project": {
                        "id": "TeklaStructuresIntegrationTests_Farmi",
                        "name": "Taf",
                        "parentProjectId": "TeklaStructuresBuilds",
                        "href": "/app/rest/projects/id:TeklaStructuresIntegrationTests_Farmi",
                        "webUrl": "http://teamcity/project.html?projectId=TeklaStructuresIntegrationTests_Farmi"
                    }
                },
                "target": {
                    "tests": {
                        "count": 1,
                        "default": false,
                        "test": [
                            {
                                "id": "-351385894798633138",
                                "name": "Work-TAF: NUNIT_59.RebarCatalog_WPF_NunitFusionTestModel",
                                "href": "/app/rest/tests/id:-351385894798633138"
                            }
                        ]
                    }
                },
                "resolution": {
                    "type": "whenFixed"
                }
            }
        ]
    },
    "testOccurrences": {
        "href": "/app/rest/testOccurrences?locator=test:(id:-351385894798633138)",
        "default": false
    },
    "href": "/app/rest/tests/id:-351385894798633138"
}""">
