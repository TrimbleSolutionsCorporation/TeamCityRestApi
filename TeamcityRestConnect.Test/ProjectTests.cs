
namespace TeamcityRestConnect.Test
{
    using NUnit.Framework;
    using TeamcityRestConnector;
    using System.Linq;
    using System.Net;
    using TeamcityRestTypes;
    using System.Collections.Generic;
    using System;
    
    [TestFixture]
    public class ProjectTests
    {
        public HttpStatusCode CreateFTCCaseForMasterInTeamcity(List<Tuple<string, string>> categoryNamPairs, ITeamcityConfiguration configuration)
        {
            ITeamcityConnector restClient = new TeamcityConnector(new JsonTeamcityConnector());
            var projects = restClient.GetAllProjects(configuration, "TeklaStructuresIntegrationTests_Farmi_FarmiOnMaster");

            foreach (var item in categoryNamPairs)
            {
                var categoryName = item.Item1;
                var ftcName = item.Item2;

                var cat = projects.Projects.FirstOrDefault(x => x.Name.Equals(categoryName));
                if (cat == null)
                {
                    var id = categoryName.Replace(" ", "");
                    cat = restClient.CreateNewProject(configuration, categoryName, id, "TeklaStructuresIntegrationTests_Farmi_FarmiOnMaster");
                    projects.Projects.Add(cat);
                }

                var buildConfExist = cat.BuildConfigurationTypes.FirstOrDefault(x => x.Name.Equals(ftcName));
                if (buildConfExist != null)
                {
                    continue;
                }

                var content = string.Format("<?xml version=\"1.0\" encoding=\"UTF-8\" standalone=\"yes\"?><buildType id=\"{0}{3}\" name=\"{0}\" projectName=\"Tekla Structures :: Taf :: Taf On Master :: {1}\" projectId=\"{2}\" href=\"/app/rest/buildTypes/id:{0}\" webUrl=\"http://teamcity/viewType.html?buildTypeId={0}\"><project id=\"{2}\" name=\"Copy and move\" parentProjectId=\"TeklaStructuresIntegrationTests_Farmi_FarmiOnMaster\" href=\"/app/rest/projects/id:{2}\" webUrl=\"http://teamcity/project.html?projectId={2}\"/><template id=\"TeklaStructuresIntegrationTests_Farmi_FarmiOnMaster_FtcTemplate\" name=\"FTC Template\" templateFlag=\"true\" projectName=\"Tekla Structures :: Taf :: Taf On Master\" projectId=\"TeklaStructuresIntegrationTests_Farmi_FarmiOnMaster\" href=\"/app/rest/buildTypes/id:TeklaStructuresIntegrationTests_Farmi_FarmiOnMaster_FtcTemplate\"/><vcs-root-entries count=\"1\"><vcs-root-entry id=\"Structures_mainline__fast_\" inherited=\"true\"><vcs-root id=\"Structures_mainline__fast_\" name=\"Structures Work\" href=\"/app/rest/vcs-roots/id:Structures_mainline__fast_\"/><checkout-rules></checkout-rules></vcs-root-entry></vcs-root-entries><settings count=\"9\"><property name=\"allowExternalStatus\" value=\"true\" inherited=\"true\"/><property name=\"artifactRules\" value=\"%env.TEAMCITY_NUNIT_DROP_PATH%/** =&gt; NunitArtifacts.zip\" inherited=\"true\"/><property name=\"buildDefaultBranch\" value=\"true\" inherited=\"true\"/><property name=\"buildNumberCounter\" value=\"1\"/><property name=\"checkoutDirectory\" value=\"e:\\prod\\FarmiMasterTests\" inherited=\"true\"/><property name=\"checkoutMode\" value=\"ON_AGENT\" inherited=\"true\"/><property name=\"excludeDefaultBranchChanges\" value=\"false\" inherited=\"true\"/><property name=\"executionTimeoutMin\" value=\"60\" inherited=\"true\"/><property name=\"showDependenciesChanges\" value=\"true\" inherited=\"true\"/></settings><parameters count=\"7\" href=\"/app/rest/buildTypes/id:{0}/parameters\"><property name=\"DeepCleanExclusions\" value=\"BuildDrop Models\" inherited=\"true\"/><property name=\"env.MSBUILDDISABLENODERESUSE\" value=\"1\" inherited=\"true\"/><property name=\"env.TEAMCITY_NUNIT_DROP_PATH\" value=\"%teamcity.build.checkoutDir%/TestDropPath\" inherited=\"true\"/><property name=\"system.FCTToTest\" value=\"{0}\"/><property name=\"system.ModelsBasePath\" value=\"%teamcity.build.checkoutDir%\\Models\" inherited=\"true\"/><property name=\"system.NodePath\" value=\"%teamcity.tool.node-v8.9.3-win-x64%\node.exe\" inherited=\"true\"/><property name=\"system.TeamcityCheckoutFolder\" value=\"%teamcity.build.checkoutDir%\" inherited=\"true\"/></parameters><steps count=\"4\"><step id=\"RUNNER_18\" name=\"Deep Clean\" type=\"simpleRunner\" inherited=\"true\"><properties count=\"6\"><property name=\"org.jfrog.artifactory.selectedDeployableServer.deployerUsername\" value=\"If all previous steps finished successfully\"/><property name=\"org.jfrog.artifactory.selectedDeployableServer.overrideDefaultDeployerCredentials\" value=\"true\"/><property name=\"script.content\" value=\"%teamcity.tool.DeepClean%\\DeepClean.exe clean -dffx -e %DeepCleanExclusions%\"/><property name=\"secure:org.jfrog.artifactory.selectedDeployableServer.deployerPassword\"/><property name=\"teamcity.step.mode\" value=\"default\"/><property name=\"use.custom.script\" value=\"true\"/></properties></step><step id=\"RUNNER_693\" name=\"Register Dlls To GAC\" type=\"simpleRunner\" inherited=\"true\"><properties count=\"3\"><property name=\"command.executable\" value=\"register_dlls.bat\"/><property name=\"teamcity.build.workingDir\" value=\"%teamcity.build.checkoutDir%\\BuildDrop\\work\\bin_x64\"/><property name=\"teamcity.step.mode\" value=\"default\"/></properties></step><step id=\"RUNNER_643\" name=\"Run Tests\" type=\"MSBuild\" inherited=\"true\"><properties count=\"18\"><property name=\"build-file-path\" value=\"Test/FarmiTests/Smoke.msbuild\"/><property name=\"dotNetCoverage.dotCover.home.path\" value=\"%teamcity.tool.JetBrains.dotCover.CommandLineTools.DEFAULT%\"/><property name=\"dotNetCoverage.NCover.HTMLReport.File.Sort\" value=\"0\"/><property name=\"dotNetCoverage.NCover.HTMLReport.File.Type\" value=\"1\"/><property name=\"dotNetCoverage.NCover.platformBitness\" value=\"x86\"/><property name=\"dotNetCoverage.NCover.platformVersion\" value=\"v2.0\"/><property name=\"dotNetCoverage.NCover3.args\" value=\"//ias .*\"/><property name=\"dotNetCoverage.NCover3.platformBitness\" value=\"x86\"/><property name=\"dotNetCoverage.NCover3.platformVersion\" value=\"v2.0\"/><property name=\"dotNetCoverage.NCover3.reporter.executable.args\" value=\"//or FullCoverageReport:Html:{{teamcity.report.path}}\"/><property name=\"dotNetCoverage.PartCover.includes\" value=\"[*]*\"/><property name=\"dotNetCoverage.PartCover.platformBitness\" value=\"x86\"/><property name=\"dotNetCoverage.PartCover.platformVersion\" value=\"v2.0\"/><property name=\"msbuild_version\" value=\"14.0\"/><property name=\"run-platform\" value=\"x86\"/><property name=\"targets\" value=\"RunCustomTest\"/><property name=\"teamcity.step.mode\" value=\"default\"/><property name=\"toolsVersion\" value=\"14.0\"/></properties></step><step id=\"RUNNER_813\" name=\"wipe binaries\" type=\"simpleRunner\" inherited=\"true\"><properties count=\"3\"><property name=\"command.executable\" value=\"rmdir\"/><property name=\"command.parameters\" value=\"BuildDrop /s /q\"/><property name=\"teamcity.step.mode\" value=\"execute_always\"/></properties></step></steps><features count=\"6\"><feature id=\"perfmon\" type=\"perfmon\" inherited=\"true\"/><feature id=\"BUILD_EXT_421\" type=\"BuildFailureOnMessage\" inherited=\"true\"><properties count=\"4\"><property name=\"buildFailureOnMessage.conditionType\" value=\"contains\"/><property name=\"buildFailureOnMessage.messagePattern\" value=\"Test exceeded Timeout value of\"/><property name=\"buildFailureOnMessage.outputText\" value=\"Test exceeded Timeout value\"/><property name=\"buildFailureOnMessage.reverse\" value=\"false\"/></properties></feature><feature id=\"BUILD_EXT_422\" type=\"BuildFailureOnMetric\" inherited=\"true\"><properties count=\"4\"><property name=\"anchorBuild\" value=\"lastSuccessful\"/><property name=\"metricKey\" value=\"buildTestCount\"/><property name=\"metricThreshold\" value=\"1\"/><property name=\"moreOrLess\" value=\"less\"/></properties></feature><feature id=\"BUILD_EXT_423\" type=\"BuildFailureOnMessage\" inherited=\"true\"><properties count=\"3\"><property name=\"buildFailureOnMessage.conditionType\" value=\"contains\"/><property name=\"buildFailureOnMessage.messagePattern\" value=\"Administrator permissions are needed to use the selected options. Use an administrator command prompt to complete these tasks.\"/><property name=\"buildFailureOnMessage.reverse\" value=\"false\"/></properties></feature><feature id=\"BUILD_EXT_424\" type=\"BuildFailureOnMessage\" inherited=\"true\"><properties count=\"4\"><property name=\"buildFailureOnMessage.conditionType\" value=\"contains\"/><property name=\"buildFailureOnMessage.messagePattern\" value=\"Tests run: 0, Passed: 0, Errors: 0, Failures: 0, Inconclusive: 0\"/><property name=\"buildFailureOnMessage.outputText\" value=\"Test Assembly Incorrectly Specified or Not Found\"/><property name=\"buildFailureOnMessage.reverse\" value=\"false\"/></properties></feature><feature id=\"BUILD_EXT_425\" type=\"BuildFailureOnMessage\" inherited=\"true\"><properties count=\"4\"><property name=\"buildFailureOnMessage.conditionType\" value=\"contains\"/><property name=\"buildFailureOnMessage.messagePattern\" value=\"System.Runtime.Remoting.RemotingException : Failed to connect to an IPC Port: The system cannot find the file specified.\"/><property name=\"buildFailureOnMessage.outputText\" value=\"At least on test or more has failed to Connect to TS, TS might have crashed\"/><property name=\"buildFailureOnMessage.reverse\" value=\"false\"/></properties></feature></features><triggers count=\"0\"/><snapshot-dependencies count=\"1\"><snapshot-dependency id=\"TSChainFast_StructuresWorkBuild_TeklaStructuresX64Release\" type=\"snapshot_dependency\" inherited=\"true\"><properties count=\"5\"><property name=\"run-build-if-dependency-failed\" value=\"RUN_ADD_PROBLEM\"/><property name=\"run-build-if-dependency-failed-to-start\" value=\"MAKE_FAILED_TO_START\"/><property name=\"run-build-on-the-same-agent\" value=\"false\"/><property name=\"take-started-build-with-same-revisions\" value=\"true\"/><property name=\"take-successful-builds-only\" value=\"true\"/></properties><source-buildType id=\"TSChainFast_StructuresWorkBuild_TeklaStructuresX64Release\" name=\"x64 Release\" projectName=\"Tekla Structures :: Work - Master :: Structures Builds\" projectId=\"TSChainFast_StructuresWorkBuild\" href=\"/app/rest/buildTypes/id:TSChainFast_StructuresWorkBuild_TeklaStructuresX64Release\" webUrl=\"http://teamcity/viewType.html?buildTypeId=TSChainFast_StructuresWorkBuild_TeklaStructuresX64Release\"/></snapshot-dependency></snapshot-dependencies><artifact-dependencies count=\"4\"><artifact-dependency id=\"ARTIFACT_DEPENDENCY_522\" type=\"artifact_dependency\" inherited=\"true\"><properties count=\"4\"><property name=\"cleanDestinationDirectory\" value=\"false\"/><property name=\"pathRules\" value=\"TeklaStructuresDailyBuild_WORK_x64.zip!nt\\bin\\** =&gt; BuildDrop\\work\\bin_x64\"/><property name=\"revisionName\" value=\"sameChainOrLastFinished\"/><property name=\"revisionValue\" value=\"latest.sameChainOrLastFinished\"/></properties><source-buildType id=\"TSChainFast_StructuresWorkBuild_TeklaStructuresX64Release\" name=\"x64 Release\" projectName=\"Tekla Structures :: Work - Master :: Structures Builds\" projectId=\"TSChainFast_StructuresWorkBuild\" href=\"/app/rest/buildTypes/id:TSChainFast_StructuresWorkBuild_TeklaStructuresX64Release\" webUrl=\"http://teamcity/viewType.html?buildTypeId=TSChainFast_StructuresWorkBuild_TeklaStructuresX64Release\"/></artifact-dependency><artifact-dependency id=\"ARTIFACT_DEPENDENCY_617\" type=\"artifact_dependency\" inherited=\"true\"><properties count=\"4\"><property name=\"cleanDestinationDirectory\" value=\"false\"/><property name=\"pathRules\" value=\"RPCApplicationsReleaseWin32.zip!** =&gt; BuildDrop\\Work\\applications\"/><property name=\"revisionName\" value=\"lastSuccessful\"/><property name=\"revisionValue\" value=\"latest.lastSuccessful\"/></properties><source-buildType id=\"TeklaStructuresExternalComponents_RpcApplicationsVersionsRelease\" name=\"RPC Applications Versions Release\" description=\"RPC Applications Win32 Debug\" projectName=\"Tekla Structures :: Internal Extensions :: RPC Applications\" projectId=\"TeklaStructuresExternalComponents_RpcApplications\" href=\"/app/rest/buildTypes/id:TeklaStructuresExternalComponents_RpcApplicationsVersionsRelease\" webUrl=\"http://teamcity/viewType.html?buildTypeId=TeklaStructuresExternalComponents_RpcApplicationsVersionsRelease\"/></artifact-dependency><artifact-dependency id=\"ARTIFACT_DEPENDENCY_616\" type=\"artifact_dependency\" inherited=\"true\"><properties count=\"4\"><property name=\"cleanDestinationDirectory\" value=\"false\"/><property name=\"pathRules\" value=\"Environments.zip!** =&gt; BuildDrop\\TSEnvironment\"/><property name=\"revisionName\" value=\"lastSuccessful\"/><property name=\"revisionValue\" value=\"latest.lastSuccessful\"/></properties><source-buildType id=\"TeklaStructuresIntegrationTests_Work_PackageEnvironments\" name=\"PackageEnvironments\" description=\"PackageEnvironments\" projectName=\"Tekla Structures :: Integration Tests :: Nunit Tests :: Work\" projectId=\"TeklaStructuresIntegrationTests_Work\" href=\"/app/rest/buildTypes/id:TeklaStructuresIntegrationTests_Work_PackageEnvironments\" webUrl=\"http://teamcity/viewType.html?buildTypeId=TeklaStructuresIntegrationTests_Work_PackageEnvironments\"/></artifact-dependency><artifact-dependency id=\"ARTIFACT_DEPENDENCY_624\" type=\"artifact_dependency\" inherited=\"true\"><properties count=\"4\"><property name=\"cleanDestinationDirectory\" value=\"false\"/><property name=\"pathRules\" value=\"Models.zip!** =&gt; Models\"/><property name=\"revisionName\" value=\"lastSuccessful\"/><property name=\"revisionValue\" value=\"latest.lastSuccessful\"/></properties><source-buildType id=\"TeklaStructuresIntegrationTests_Farmi_PackageFarmiModels\" name=\"PackageFarmiModels\" description=\"PackageEnvironments\" projectName=\"Tekla Structures :: Taf\" projectId=\"TeklaStructuresIntegrationTests_Farmi\" href=\"/app/rest/buildTypes/id:TeklaStructuresIntegrationTests_Farmi_PackageFarmiModels\" webUrl=\"http://teamcity/viewType.html?buildTypeId=TeklaStructuresIntegrationTests_Farmi_PackageFarmiModels\"/></artifact-dependency></artifact-dependencies><agent-requirements count=\"0\"/><builds href=\"/app/rest/buildTypes/id:{0}/builds/\"/><investigations href=\"/app/rest/investigations?locator=buildType:(id:{0})\"/><compatibleAgents href=\"/app/rest/agents?locator=compatible:(buildType:(id:{0}))\"/></buildType>",
                    ftcName, cat.Name, cat.Id, cat.Id.Replace(" ", ""));

                var reply = restClient.CreateBuildConfiguration(configuration, content);
                Assert.NotNull(reply);
            }

            return HttpStatusCode.OK;
        }

        [Test]
        public void TestDisableAgent()
        {
            var configuration = new Configuration();
            ITeamcityConnector restClient = new TeamcityConnector(new JsonTeamcityConnector());
            Assert.That(restClient.DisableAgent(configuration, "395"), Is.True);
        }

        [Test]
        public void TestDisableAgentQueue()
        {
            var configuration = new Configuration();
            ITeamcityConnector restClient = new TeamcityConnector(new JsonTeamcityConnector());
            var builds = restClient.GetQueuedBuilds(configuration);
            Assert.That(builds, Is.True);
        }


        [Test]
        public void TestCreateProject()
        {
            var configuration = new Configuration();
            var configs = new List<Tuple<string, string>>();
            configs.Add(new Tuple<string, string>("General", "FTC_2046"));
            configs.Add(new Tuple<string, string>("General", "FTC_2730"));

            Assert.That(CreateFTCCaseForMasterInTeamcity(configs, configuration), Is.EqualTo(HttpStatusCode.OK));
        }

        [Test]
        public void TestDeleteProject()
        {
            var configuration = new Configuration();
            ITeamcityConnector restClient = new TeamcityConnector(new JsonTeamcityConnector());
            var projects = restClient.GetAllProjects(configuration, "TeklaStructuresIntegrationTests_Farmi_FarmiOnMaster");

            foreach (var project in projects.Projects)
            {
                Assert.True(restClient.DeleteProject(configuration, project.Id));
            }
        }
    }
}
