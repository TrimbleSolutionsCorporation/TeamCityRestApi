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
            "builds": {
                "build": [
                    {
                        "id": 15872895,
                        "buildTypeId": "TeklaStructuresIntegrationTests_Farmi_FarmiOnMaster_PinpointFailedTest",
                        "number": "5666",
                        "status": "FAILURE",
                        "state": "finished",
                        "branchName": "master",
                        "href": "/app/rest/builds/id:15872895",
                        "webUrl": "http://teamcity/viewLog.html?buildId=15872895&buildTypeId=TeklaStructuresIntegrationTests_Farmi_FarmiOnMaster_PinpointFailedTest"
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
        "status": true,
        "comment": {
            "timestamp": "20181025T132138+0300",
            "user": {
                "username": "jjh",
                "name": "as asd",
                "id": 5,
                "href": "/app/rest/users/id:5"
            }
        }
    },
    "authorizedInfo": {
        "status": true,
        "comment": {
            "timestamp": "20130516T112857+0300"
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
            "href": "/app/rest/agents/id:39",
            "webUrl": "http://teamcity/agentDetails.html?id=39&agentTypeId=39&realAgentName=agetnt1"
        },
        {
            "id": 72,
            "name": "agetnt2",
            "typeId": 72,
            "href": "/app/rest/agents/id:72",
            "webUrl": "http://teamcity/agentDetails.html?id=72&agentTypeId=72&realAgentName=agetnt2"
        }
    ]
}""">

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
{"count":28,"href":"/httpAuth/app/rest/buildTypes/id:BatTools_BuildAllExtension/builds/","build":[{"id":1884284,"buildTypeId":"BatTools_BuildAllExtension","number":"72.354","status":"SUCCESS","state":"finished","href":"/httpAuth/app/rest/builds/id:1884284","webUrl":"http://teamcity/viewLog.html?buildId=1884284&buildTypeId=BatTools_BuildAllExtension"},{"id":1884126,"buildTypeId":"BatTools_BuildAllExtension","number":"71","status":"SUCCESS","state":"finished","href":"/httpAuth/app/rest/builds/id:1884126","webUrl":"http://teamcity/viewLog.html?buildId=1884126&buildTypeId=BatTools_BuildAllExtension"},{"id":1884121,"buildTypeId":"BatTools_BuildAllExtension","number":"70","status":"FAILURE","state":"finished","href":"/httpAuth/app/rest/builds/id:1884121","webUrl":"http://teamcity/viewLog.html?buildId=1884121&buildTypeId=BatTools_BuildAllExtension"},{"id":1883948,"buildTypeId":"BatTools_BuildAllExtension","number":"69a","status":"FAILURE","state":"finished","href":"/httpAuth/app/rest/builds/id:1883948","webUrl":"http://teamcity/viewLog.html?buildId=1883948&buildTypeId=BatTools_BuildAllExtension"},{"id":1874662,"buildTypeId":"BatTools_BuildAllExtension","number":"68a","status":"FAILURE","state":"finished","href":"/httpAuth/app/rest/builds/id:1874662","webUrl":"http://teamcity/viewLog.html?buildId=1874662&buildTypeId=BatTools_BuildAllExtension"},{"id":1874061,"buildTypeId":"BatTools_BuildAllExtension","number":"67a","status":"FAILURE","state":"finished","href":"/httpAuth/app/rest/builds/id:1874061","webUrl":"http://teamcity/viewLog.html?buildId=1874061&buildTypeId=BatTools_BuildAllExtension"},{"id":1839966,"buildTypeId":"BatTools_BuildAllExtension","number":"66a","status":"FAILURE","state":"finished","href":"/httpAuth/app/rest/builds/id:1839966","webUrl":"http://teamcity/viewLog.html?buildId=1839966&buildTypeId=BatTools_BuildAllExtension"},{"id":1839824,"buildTypeId":"BatTools_BuildAllExtension","number":"65a","status":"SUCCESS","state":"finished","href":"/httpAuth/app/rest/builds/id:1839824","webUrl":"http://teamcity/viewLog.html?buildId=1839824&buildTypeId=BatTools_BuildAllExtension"},{"id":1839802,"buildTypeId":"BatTools_BuildAllExtension","number":"64a","status":"SUCCESS","state":"finished","href":"/httpAuth/app/rest/builds/id:1839802","webUrl":"http://teamcity/viewLog.html?buildId=1839802&buildTypeId=BatTools_BuildAllExtension"},{"id":1782937,"buildTypeId":"BatTools_BuildAllExtension","number":"63a","status":"FAILURE","state":"finished","href":"/httpAuth/app/rest/builds/id:1782937","webUrl":"http://teamcity/viewLog.html?buildId=1782937&buildTypeId=BatTools_BuildAllExtension"},{"id":1782633,"buildTypeId":"BatTools_BuildAllExtension","number":"62a","status":"FAILURE","state":"finished","href":"/httpAuth/app/rest/builds/id:1782633","webUrl":"http://teamcity/viewLog.html?buildId=1782633&buildTypeId=BatTools_BuildAllExtension"},{"id":1770755,"buildTypeId":"BatTools_BuildAllExtension","number":"61a","status":"SUCCESS","state":"finished","href":"/httpAuth/app/rest/builds/id:1770755","webUrl":"http://teamcity/viewLog.html?buildId=1770755&buildTypeId=BatTools_BuildAllExtension"},{"id":1766488,"buildTypeId":"BatTools_BuildAllExtension","number":"60a","status":"SUCCESS","state":"finished","href":"/httpAuth/app/rest/builds/id:1766488","webUrl":"http://teamcity/viewLog.html?buildId=1766488&buildTypeId=BatTools_BuildAllExtension"},{"id":1765126,"buildTypeId":"BatTools_BuildAllExtension","number":"59a","status":"SUCCESS","state":"finished","href":"/httpAuth/app/rest/builds/id:1765126","webUrl":"http://teamcity/viewLog.html?buildId=1765126&buildTypeId=BatTools_BuildAllExtension"},{"id":1762928,"buildTypeId":"BatTools_BuildAllExtension","number":"58","status":"SUCCESS","state":"finished","href":"/httpAuth/app/rest/builds/id:1762928","webUrl":"http://teamcity/viewLog.html?buildId=1762928&buildTypeId=BatTools_BuildAllExtension"},{"id":1759246,"buildTypeId":"BatTools_BuildAllExtension","number":"57","status":"SUCCESS","state":"finished","href":"/httpAuth/app/rest/builds/id:1759246","webUrl":"http://teamcity/viewLog.html?buildId=1759246&buildTypeId=BatTools_BuildAllExtension"},{"id":1758293,"buildTypeId":"BatTools_BuildAllExtension","number":"56","status":"SUCCESS","state":"finished","href":"/httpAuth/app/rest/builds/id:1758293","webUrl":"http://teamcity/viewLog.html?buildId=1758293&buildTypeId=BatTools_BuildAllExtension"},{"id":1755054,"buildTypeId":"BatTools_BuildAllExtension","number":"55","status":"SUCCESS","state":"finished","href":"/httpAuth/app/rest/builds/id:1755054","webUrl":"http://teamcity/viewLog.html?buildId=1755054&buildTypeId=BatTools_BuildAllExtension"},{"id":1754574,"buildTypeId":"BatTools_BuildAllExtension","number":"54","status":"SUCCESS","state":"finished","href":"/httpAuth/app/rest/builds/id:1754574","webUrl":"http://teamcity/viewLog.html?buildId=1754574&buildTypeId=BatTools_BuildAllExtension"},{"id":1753844,"buildTypeId":"BatTools_BuildAllExtension","number":"53","status":"SUCCESS","state":"finished","href":"/httpAuth/app/rest/builds/id:1753844","webUrl":"http://teamcity/viewLog.html?buildId=1753844&buildTypeId=BatTools_BuildAllExtension"},{"id":1744475,"buildTypeId":"BatTools_BuildAllExtension","number":"52","status":"SUCCESS","state":"finished","href":"/httpAuth/app/rest/builds/id:1744475","webUrl":"http://teamcity/viewLog.html?buildId=1744475&buildTypeId=BatTools_BuildAllExtension"},{"id":1712522,"buildTypeId":"BatTools_BuildAllExtension","number":"51","status":"SUCCESS","state":"finished","href":"/httpAuth/app/rest/builds/id:1712522","webUrl":"http://teamcity/viewLog.html?buildId=1712522&buildTypeId=BatTools_BuildAllExtension"},{"id":1708392,"buildTypeId":"BatTools_BuildAllExtension","number":"50","status":"SUCCESS","state":"finished","href":"/httpAuth/app/rest/builds/id:1708392","webUrl":"http://teamcity/viewLog.html?buildId=1708392&buildTypeId=BatTools_BuildAllExtension"},{"id":1706955,"buildTypeId":"BatTools_BuildAllExtension","number":"49","status":"SUCCESS","state":"finished","href":"/httpAuth/app/rest/builds/id:1706955","webUrl":"http://teamcity/viewLog.html?buildId=1706955&buildTypeId=BatTools_BuildAllExtension"},{"id":1706275,"buildTypeId":"BatTools_BuildAllExtension","number":"48","status":"SUCCESS","state":"finished","href":"/httpAuth/app/rest/builds/id:1706275","webUrl":"http://teamcity/viewLog.html?buildId=1706275&buildTypeId=BatTools_BuildAllExtension"},{"id":1690735,"buildTypeId":"BatTools_BuildAllExtension","number":"47","status":"FAILURE","state":"finished","href":"/httpAuth/app/rest/builds/id:1690735","webUrl":"http://teamcity/viewLog.html?buildId=1690735&buildTypeId=BatTools_BuildAllExtension"},{"id":1674764,"buildTypeId":"BatTools_BuildAllExtension","number":"46","status":"FAILURE","state":"finished","href":"/httpAuth/app/rest/builds/id:1674764","webUrl":"http://teamcity/viewLog.html?buildId=1674764&buildTypeId=BatTools_BuildAllExtension"},{"id":1673575,"buildTypeId":"BatTools_BuildAllExtension","number":"45","status":"FAILURE","state":"finished","href":"/httpAuth/app/rest/builds/id:1673575","webUrl":"http://teamcity/viewLog.html?buildId=1673575&buildTypeId=BatTools_BuildAllExtension"}]} """>

type QueuedBuildResponse = JsonProvider<"""
{"count":40,"href":"/httpAuth/app/rest/buildQueue","build":[{"taskId":8709158,"buildTypeId":"TsFast_DebugWin32WithCoverage","state":"queued","branchName":"<default>","defaultBranch":true,"href":"/httpAuth/app/rest/buildQueue/taskId:8709158","webUrl":"http://teamcity/viewQueued.html?itemId=8709158"},{"buildTypeId":"TeklaStructuresIntegrationTests_WorkWin32DebugCoverage_AnalyseSonarQubeExtension","state":"queued","href":"/httpAuth/app/rest/buildQueue/taskId:8706942","webUrl":"http://teamcity/viewQueued.html?itemId=8706942"},{"taskId":8709367,"buildTypeId":"TeklaStructuresIntegrationTests_WorkX64Release_TeklaStructuresDrawingTestSlowe","state":"queued","href":"/httpAuth/app/rest/buildQueue/taskId:8709367","webUrl":"http://teamcity/viewQueued.html?itemId=8709367"},{"taskId":8709018,"buildTypeId":"bt9900701","state":"queued","href":"/httpAuth/app/rest/buildQueue/taskId:8709018","webUrl":"http://teamcity/viewQueued.html?itemId=8709018"},{"taskId":8709451,"buildTypeId":"TSChainFast_CreateDailyBuild","state":"queued","branchName":"refs/heads/master","defaultBranch":true,"href":"/httpAuth/app/rest/buildQueue/taskId:8709451","webUrl":"http://teamcity/viewQueued.html?itemId=8709451"},{"taskId":8709457,"buildTypeId":"TSChainFast_DailyDebug","state":"queued","branchName":"refs/heads/master","defaultBranch":true,"href":"/httpAuth/app/rest/buildQueue/taskId:8709457","webUrl":"http://teamcity/viewQueued.html?itemId=8709457"},{"taskId":8709458,"buildTypeId":"TSChainFast_CreateWorkWin32TeklaStructuresInstaller","state":"queued","href":"/httpAuth/app/rest/buildQueue/taskId:8709458","webUrl":"http://teamcity/viewQueued.html?itemId=8709458"},{"taskId":8709531,"buildTypeId":"TSChainFast_Modelx64Release","state":"queued","branchName":"refs/heads/master","defaultBranch":true,"href":"/httpAuth/app/rest/buildQueue/taskId:8709531","webUrl":"http://teamcity/viewQueued.html?itemId=8709531"},{"taskId":8709529,"buildTypeId":"TSChainFast_Drawingsx64Release","state":"queued","branchName":"refs/heads/master","defaultBranch":true,"href":"/httpAuth/app/rest/buildQueue/taskId:8709529","webUrl":"http://teamcity/viewQueued.html?itemId=8709529"},{"taskId":8709530,"buildTypeId":"TSChainFast_DotNetAppsx64Release","state":"queued","branchName":"refs/heads/master","defaultBranch":true,"href":"/httpAuth/app/rest/buildQueue/taskId:8709530","webUrl":"http://teamcity/viewQueued.html?itemId=8709530"},{"taskId":8709532,"buildTypeId":"TSChainFast_TeklaStructuresx64Release","state":"queued","branchName":"refs/heads/master","defaultBranch":true,"href":"/httpAuth/app/rest/buildQueue/taskId:8709532","webUrl":"http://teamcity/viewQueued.html?itemId=8709532"},{"taskId":8709533,"buildTypeId":"TSChainFast_Dailyx64Release","state":"queued","branchName":"refs/heads/master","defaultBranch":true,"href":"/httpAuth/app/rest/buildQueue/taskId:8709533","webUrl":"http://teamcity/viewQueued.html?itemId=8709533"},{"taskId":8709534,"buildTypeId":"TSChainFast_DeploymentInstallers_CopyWorkX64DailybuildToFarmiAndTsLive","state":"queued","href":"/httpAuth/app/rest/buildQueue/taskId:8709534","webUrl":"http://teamcity/viewQueued.html?itemId=8709534"},{"taskId":8709512,"buildTypeId":"TeklaStructuresX64Configuration_DeployAssembliesDebug","state":"queued","branchName":"refs/heads/master","defaultBranch":true,"href":"/httpAuth/app/rest/buildQueue/taskId:8709512","webUrl":"http://teamcity/viewQueued.html?itemId=8709512"},{"taskId":8709515,"buildTypeId":"TSChainFast_ModelDebugx64","state":"queued","branchName":"refs/heads/master","defaultBranch":true,"href":"/httpAuth/app/rest/buildQueue/taskId:8709515","webUrl":"http://teamcity/viewQueued.html?itemId=8709515"},{"taskId":8709513,"buildTypeId":"TSChainFast_Drawingsx64Debug","state":"queued","branchName":"refs/heads/master","defaultBranch":true,"href":"/httpAuth/app/rest/buildQueue/taskId:8709513","webUrl":"http://teamcity/viewQueued.html?itemId=8709513"},{"taskId":8709514,"buildTypeId":"TSChainFast_DotNetAppsx64Debug","state":"queued","branchName":"refs/heads/master","defaultBranch":true,"href":"/httpAuth/app/rest/buildQueue/taskId:8709514","webUrl":"http://teamcity/viewQueued.html?itemId=8709514"},{"taskId":8709516,"buildTypeId":"TSChainFast_TeklaStructuresWinDebug","state":"queued","branchName":"refs/heads/master","defaultBranch":true,"href":"/httpAuth/app/rest/buildQueue/taskId:8709516","webUrl":"http://teamcity/viewQueued.html?itemId=8709516"},{"taskId":8709517,"buildTypeId":"TSChainFast_Dailyx64Debug","state":"queued","branchName":"refs/heads/master","defaultBranch":true,"href":"/httpAuth/app/rest/buildQueue/taskId:8709517","webUrl":"http://teamcity/viewQueued.html?itemId=8709517"},{"taskId":8709526,"buildTypeId":"TSChainFast_TsWin32fast_ModelTester","state":"queued","branchName":"refs/heads/master","defaultBranch":true,"href":"/httpAuth/app/rest/buildQueue/taskId:8709526","webUrl":"http://teamcity/viewQueued.html?itemId=8709526"},{"taskId":8709459,"buildTypeId":"TSChainFast_DeploymentInstallers_CopyWorkWin32InstallersZipsEnvsToAManta","state":"queued","href":"/httpAuth/app/rest/buildQueue/taskId:8709459","webUrl":"http://teamcity/viewQueued.html?itemId=8709459"},{"taskId":8709479,"buildTypeId":"TsDailyBranches_Win32x64BugFix_2_TeklaStructuresX64Debug","state":"queued","branchName":"107087-DPMPrinter-jpeg-does-not-appear-correctly-19.1","href":"/httpAuth/app/rest/buildQueue/taskId:8709479","webUrl":"http://teamcity/viewQueued.html?itemId=8709479"},{"taskId":8709480,"buildTypeId":"TsDailyBranches_Win32x64BugFix_2_TeklaStructuresWin32Release","state":"queued","branchName":"107087-DPMPrinter-jpeg-does-not-appear-correctly-19.1","href":"/httpAuth/app/rest/buildQueue/taskId:8709480","webUrl":"http://teamcity/viewQueued.html?itemId=8709480"},{"taskId":8709670,"buildTypeId":"TSChainFast_StructuresWorkBuild_Win32x64Features_ModelTesterWin32Releas","state":"queued","branchName":"107504_fix-Sketch-Cham-parameterisation","href":"/httpAuth/app/rest/buildQueue/taskId:8709670","webUrl":"http://teamcity/viewQueued.html?itemId=8709670"},{"taskId":8709432,"buildTypeId":"TsDailyBranches_Win32x64BugFix_2_TeklaStructuresWin32Release","state":"queued","branchName":"107087-DPMPrinter-jpeg-does-not-appear-correctly-20.1","href":"/httpAuth/app/rest/buildQueue/taskId:8709432","webUrl":"http://teamcity/viewQueued.html?itemId=8709432"},{"taskId":8709556,"buildTypeId":"TeklaStructuresIntegrationTests_WorkX64DebugNew_TeklaStructuresModelComponentTe","state":"queued","href":"/httpAuth/app/rest/buildQueue/taskId:8709556","webUrl":"http://teamcity/viewQueued.html?itemId=8709556"},{"taskId":8709577,"buildTypeId":"TeklaStructuresIntegrationTests_WorkX64DebugNew_TeklaStructuresModelTestViewTes","state":"queued","href":"/httpAuth/app/rest/buildQueue/taskId:8709577","webUrl":"http://teamcity/viewQueued.html?itemId=8709577"},{"taskId":8709584,"buildTypeId":"TeklaStructuresIntegrationTests_WorkX64DebugNew_SlabReinforcementToolTest","state":"queued","href":"/httpAuth/app/rest/buildQueue/taskId:8709584","webUrl":"http://teamcity/viewQueued.html?itemId=8709584"},{"taskId":8709591,"buildTypeId":"TeklaStructuresIntegrationTests_WorkX64DebugNew_RebarLayeringMarkerTest","state":"queued","href":"/httpAuth/app/rest/buildQueue/taskId:8709591","webUrl":"http://teamcity/viewQueued.html?itemId=8709591"},{"taskId":8709598,"buildTypeId":"TeklaStructuresIntegrationTests_WorkX64DebugNew_TaskManagerUnitTests","state":"queued","href":"/httpAuth/app/rest/buildQueue/taskId:8709598","webUrl":"http://teamcity/viewQueued.html?itemId=8709598"},{"taskId":8709605,"buildTypeId":"TeklaStructuresIntegrationTests_WorkX64DebugNew_ContinuousBeamReinforcementTest","state":"queued","href":"/httpAuth/app/rest/buildQueue/taskId:8709605","webUrl":"http://teamcity/viewQueued.html?itemId=8709605"},{"taskId":8709612,"buildTypeId":"TeklaStructuresIntegrationTests_WorkX64DebugNew_ProjectOrganizerTestsCm","state":"queued","href":"/httpAuth/app/rest/buildQueue/taskId:8709612","webUrl":"http://teamcity/viewQueued.html?itemId=8709612"},{"taskId":8709619,"buildTypeId":"TeklaStructuresIntegrationTests_WorkX64DebugNew_DPMPrinterTest","state":"queued","href":"/httpAuth/app/rest/buildQueue/taskId:8709619","webUrl":"http://teamcity/viewQueued.html?itemId=8709619"},{"taskId":8709626,"buildTypeId":"TeklaStructuresIntegrationTests_WorkX64DebugNew_TeklaStructuresAnalysisTest","state":"queued","href":"/httpAuth/app/rest/buildQueue/taskId:8709626","webUrl":"http://teamcity/viewQueued.html?itemId=8709626"},{"taskId":8709633,"buildTypeId":"TeklaStructuresIntegrationTests_WorkX64DebugNew_TeklaStructuresCatalogTest","state":"queued","href":"/httpAuth/app/rest/buildQueue/taskId:8709633","webUrl":"http://teamcity/viewQueued.html?itemId=8709633"},{"taskId":8709640,"buildTypeId":"TeklaStructuresIntegrationTests_WorkX64DebugNew_TeklaStructuresDialogTest","state":"queued","href":"/httpAuth/app/rest/buildQueue/taskId:8709640","webUrl":"http://teamcity/viewQueued.html?itemId=8709640"},{"taskId":8709647,"buildTypeId":"TeklaStructuresIntegrationTests_WorkX64DebugNew_TeklaStructuresDrawingTest","state":"queued","href":"/httpAuth/app/rest/buildQueue/taskId:8709647","webUrl":"http://teamcity/viewQueued.html?itemId=8709647"},{"taskId":8709654,"buildTypeId":"TeklaStructuresIntegrationTests_WorkX64DebugNew_TeklaStructuresDatatypeTest","state":"queued","href":"/httpAuth/app/rest/buildQueue/taskId:8709654","webUrl":"http://teamcity/viewQueued.html?itemId=8709654"},{"taskId":8709661,"buildTypeId":"TeklaStructuresIntegrationTests_WorkX64DebugNew_TeklaStructuresModelSharedWithHi","state":"queued","href":"/httpAuth/app/rest/buildQueue/taskId:8709661","webUrl":"http://teamcity/viewQueued.html?itemId=8709661"},{"taskId":8709668,"buildTypeId":"TeklaStructuresIntegrationTests_WorkX64DebugNew_TeklaStructuresTest","state":"queued","href":"/httpAuth/app/rest/buildQueue/taskId:8709668","webUrl":"http://teamcity/viewQueued.html?itemId=8709668"}]} """>

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

type TestDetailsJson = JsonProvider<"""{"id":"id:503,build:(id:14783632)","name":"FTC_2728.EmptyModel","status":"FAILURE","duration":123466,"muted":true,"currentlyMuted":true,"currentlyInvestigated":true,"href":"/app/rest/testOccurrences/id:503,build:(id:14783632)","details":"Test Generated Incorrect References, Check Diff Report\nThe following error messages were found : \r\n \r\n\r\n\r\n\r\nFTC_2728.EmptyModel Asserts in teklastructures/libapplication/appl_user_model_role.cpp:248 with Message: Could not retrieve current user or model guid\r\nFTC_2728.EmptyModel Asserts in teklastructures/libapplication/appl_user_model_role.cpp:248 with Message: Could not retrieve current user or model guid\r\n See Teamcity artifacts to evalute the generated diff. Build => Artifacts section.","test":{"id":"3917745388714076008","name":"FTC_2728.EmptyModel","href":"/app/rest/tests/id:3917745388714076008"},"mute":{"id":6803,"href":"/app/rest/mutes/id:6803","assignment":{"timestamp":"20190614T140526+0300","text":"TTSD-26111","user":{"username":"jocs","name":"Costa Jorge","id":5,"href":"/app/rest/users/id:5"}},"scope":{"project":{"id":"TeklaStructuresIntegrationTests_Farmi","name":"Taf","parentProjectId":"TeklaStructuresBuilds","href":"/app/rest/projects/id:TeklaStructuresIntegrationTests_Farmi","webUrl":"http://teamcity/project.html?projectId=TeklaStructuresIntegrationTests_Farmi"}},"target":{"tests":{"count":1,"default":false,"test":[{"id":"3917745388714076008","name":"FTC_2728.EmptyModel","href":"/app/rest/tests/id:3917745388714076008"}]}},"resolution":{"type":"whenFixed"}},"build":{"id":14783632,"buildTypeId":"FTC_2728_TeklaStructuresIntegrationTestsFarmiFarmiOnMasterMultiuseModelSharing","number":"803","status":"SUCCESS","state":"finished","branchName":"master","defaultBranch":true,"href":"/app/rest/builds/id:14783632","webUrl":"http://teamcity/viewLog.html?buildId=14783632&buildTypeId=FTC_2728_TeklaStructuresIntegrationTestsFarmiFarmiOnMasterMultiuseModelSharing"},"firstFailed":{"id":"id:484,build:(id:14770049)","name":"FTC_2728.EmptyModel","status":"FAILURE","duration":122905,"muted":true,"currentlyMuted":true,"currentlyInvestigated":true,"href":"/app/rest/testOccurrences/id:484,build:(id:14770049)"}}""">