# Test Plan #
## Scope ##

A test plan for the cs2450 library simulator team.

## References ##

The [Project home](http://code.google.com/p/librarysim/)<br>
The <a href='http://code.google.com/p/librarysim/w/list'>Product wiki</a><br>
The <a href='http://code.google.com/p/librarysim/source/browse/'>Project source</a><br>
The <a href='http://code.google.com/p/librarysim/issues/listh'>Project bugs</a><br>
The <a href='http://code.google.com/p/librarysim/downloads/list'>Project downloads</a><br>

<h2>QA Meetings</h2>

No meetings scheduled<br>
<br>
<h2>Definitions</h2>

.NET C#---(pronounced "C Sharp") is an object-oriented programming language developed by Microsoft Corporation as part of their .NET initiative in response to the success of Sun Microsystems' Java programming language. C# source code—as well as those of other .NET languages—is compiled into an intermediate byte code called Microsoft Intermediate Language (MSIL).<br><br>
SQLite---SQLite is a software library that implements a self-contained, serverless, zero-configuration, transactional SQL database engine.<br><br>

<h2>Test plan</h2>
<h3>Purpose</h3>

This document is a comprehensive test strategy to be used by testers to ensure proper and exhaustive testing.  It also acts as a reference for all stakeholders wishing to obtain information on current and past testing efforts.<br>
<br>
<h3>Outline</h3>

<h4><u>Test plan identifier</u></h4>
The purpose of this section is to identify the current and previous versions of the test plan, its level, and the version of software it pertains to.<br>
{| class="wikitable" border="1" style="text-align:center"<br>
|-<br>
! ID<br>
! Level<br>
! Software Version<br>
! Modify Time<br>
! Author<br>
|-<br>
| Librarysim-TP-V0.1<br>
| Draft<br>
| N/A<br>
| 04-01-2009<br>
| Stephen<br>
|-<br>
|<br>
|<br>
|<br>
|<br>
|<br>
|-<br>
|<br>
|<br>
|<br>
|<br>
|<br>
|-<br>
|<br>
|<br>
|<br>
|<br>
|<br>
|-<br>
|}<br>
<br>
<h4><u>Introduction</u></h4>
Testing efforts will be related to the project goals, which are:<br>
<br>
<b>Create a system that managers patrons, books, and media.<br></b>Be able change dates<br>
<br>
This plan includes integration, system, and acceptance testing.<br>
<br>
Integration testing to be completed in 2009.<br><br>
System testing will be performed in 2009.<br><br>
Acceptance testing will be performed later in 2009 before the product is released.  During system testing, the product should be tested in its entirety from the end user's point of view.<br><br>

<h4><u>Test items</u></h4>

According to the project plan, test items is below:<br>
<br>
Test Components:<br>
{| class="wikitable" border="1" style="text-align:center"<br>
|-<br>
! Test Items<br>
! Priority(S1/S2/S3)<br>
! Schedule<br>
|-<br>
| X<br>
| S1<br>
|<br>
|-<br>
| Y<br>
| S1<br>
|<br>
|-<br>
| Z<br>
| S1<br>
|<br>
|-<br>
|<br>
| S1<br>
|<br>
|-<br>
|<br>
| S1<br>
|<br>
|-<br>
|}<br>
<br>
<h4><u>Software risk issues</u></h4>
''This section describes any risks resulting from lack of time and/or resources.''<br>
<b>frequent changes to requirements and/or design.<br></b>loss of time<br>
<br>
<h4><u>Features to be tested</u></h4>
''Abstraction of test items.  What will be tested from the user or customer point of view.''<br><br>

<h5>Database</h5>

<b>X</b>

<h5>UI</h5>
<h5>Check in</h5>
<h5>Check out</h5>
<h5>Patrons</h5>
<b>Add a patron<br></b>Remove a patron<br>
<br>
<br>
<br>
<h4><u>Features not to be tested</u></h4>

''Any features that will not be tested and why.  Decisions not to test a feature should be based on priority and risk.  If a feature will not be tested, define what features (class, methods, properties) will not be tested.''<br>
<br>
At this time we plan to test all features exhaustively.<br>
<br>
<h4><u>Approach</u></h4>

''A description of how and where testing will be performed and explain any issues that have a major impact on the success of testing and ultimately on the project.''<br>
<br>
<h5>General Guidelines</h5>

<b>Tests shall be automated whenever possible.  Time constraint is not a good excuse not to automate.</b><br><br>
<b>Test plan will be developed using the IEEE Std. 829-1998 Standard for Software Test Documentation.</b><br><br>
<b>All bugs shall be logged in <a href='http://code.google.com/p/librarysim/issues/list'>Issues</a> at the time they are found.</b><br><br>
<b><br></b>When a bug's status is changed to VERIFIED in Bugzilla, the reporter of the bug should change the bug's status to CLOSED or reopen the bug as soon as possible. If the person who reported the bug verifies the bug, the bug can be closed without having its status changed to VERIFIED. A bug should not be closed by someone who did not report the bug unless the reporter is unavailable.<br><br>
<b>Types of system testing include function, performance, security, load, reliability, usability, documentation testing.</b><br><br>
<b>Acceptance criteria for patch acceptance: Before a patch is accepted, a QA engineer must ensure that the patch submitted from developer passes QA testing.   A build engineer must ensure the patch builds properly and meets packaging standards. QA and build engineers will then create a patch acceptance report, and the patch can be included in the product.</b><br><br>
<b>Testers may perform system testing on the product only after development has verified that they have completed a development milestone and the build team has created a stable release.</b><br><br>

<b>No regularly scheduled meetings at this time</b><br><br>
<b>Minor editing (grammar and spelling corrections) of this test plan can be done at any time.  Any change to the test plan that changes how the product will be tested shall be approved by the QA team who will determine if the changes are large enough to require a change to the test plan identifier.</b><br><br>
<b>Black box and white box testing methods are both acceptable.  However, it is anticipated that black box testing will be the norm.</b><br><br>
<b>Integration testing will involve the iterative testing of new developer code as it becomes available and it is integrated into the product.  System testing will begin after provider and client pieces has been implemented and released.</b><br><br>
<b>Exit criteria has yet to be established.  This should be discussed with project management.</b><br><br>


<h4><u>Item pass/fail criteria</u></h4>

The pass/fail criteria for each of the items described in Test Items section.<br>
<br>
Criteria for Test Components:<br>
{| class="wikitable" border="1" style="text-align:center"<br>
|-<br>
! Test Items<br>
! Pass<br>
! Fail<br>
|-<br>
|<br>
| ?<br>
|<br>
|-<br>
|<br>
| ?<br>
|<br>
|-<br>
|<br>
| ?<br>
|<br>
|-<br>
|<br>
| ?<br>
|<br>
|-<br>
|<br>
| ?<br>
|<br>
|-<br>
|<br>
| ?<br>
|<br>
|-<br>
|}<br>
<br>
Individual test case pass/fail criterion is defined by the automated script which performs the testing.  Upon failure of a test case, the script should will log the failure.<br>
<br>
<h4><u>Suspension criteria and resumption requirements</u></h4>
Suspension criteria:<br>
<b>Unavailability of external dependency during execution.<br></b>When a defect is introduced that cannot allow any further testing (i.e., a blocker bug).<br>
<b>Critical path deadline is missed so that the client will not accept delivery even if all testing is completed.<br></b>A specific holiday shuts down both development and testing.<br>
<b>Lack of testing resources (e.g., testers, hardware, etc).</b>

Resumption requirements:<br>
<b>When the external dependent systems become available again.<br></b>When a fix is successfully implemented and the testing team is notified to continue testing.<br>
<b>The contract is renegotiated with the client to extend delivery.<br></b>The holiday period ends.<br>
<b>Testing resources become available</b>

A failed build would not constitute suspension as we could generally continue to use the previous build. Major or critical defects would also not constitute suspension as other areas of the system could continue to be tested.<br>
<br>
<h4><u>Test deliverables</u></h4>
''All documents, tools, and other components that are to be developed and maintained in support of the testing effort''<br>
<b>Test plan (this document)<br></b> Test cases - none at this time<br>
<b>Custom tools - test harness, test scripts, sample applications<br></b> Defect reports - none at this time<br>
<b>Test summary reports - none at this time<br></b> Other - none at this time<br>
<br>
<h4><u>Testing preparation and setup</u></h4>
''set of tasks necessary to prepare for and perform testing''<br>
<br>
Team Setup:<br>
{| class="wikitable" border="1" style="text-align:left"<br>
|-<br>
! Task<br>
! Finished<br>
|-<br>
|Obtain testable build<br>
|X<br>
|-<br>
|<br>
|X<br>
|-<br>
|<br>
|X<br>
|-<br>
|<br>
|X<br>
|}<br>
<br>
X = Done<br>
P = In Progress<br>
<br>
Individual Preparation:<br>
<b>Create a google account<br></b>Install VS and/or monodevelop<br>
<b>Install most recent .NET and/or Mono</b>

<h4><u>Environmental needs</u></h4>
''Hardware, software, data, interfaces, facilities, publications, other requirements that pertain to the testing effort''<br>
<br>
Testing may be done on physical and virtual machines.<br>
<br>
All tests must be performed on the most recent official release of the following platforms:<br>
<br>
{| class="wikitable" border="1" style="text-align:center"<br>
|-<br>
!<br>
! x86<br>
! x86_64<br>
|-<br>
| windows<br>
| X<br>
| X<br>
|-<br>
| openSUSE<br>
| X<br>
| X<br>
|-<br>
|<br>
|<br>
|<br>
|}<br>
<br>
Hardware:<br>
<b>No specific hardware requirements at this time</b>

Software:<br>
<b>.NET or Mono - most recent release<br></b>VS or monodevelop<br>
<br>
<h4><u>Responsibilities</u></h4>

All testers can work wherever they are needed, however, below is where our team focuses their efforts at this time:<br>
<br>
'''X Tests:''' team-member1<br>
'''Y Tests:''' team-member2<br>
'''Z Harness:''' team-member3<br>
<br>
<h4><u>Staffing and training needs</u></h4>
<b>QA Engineer (3)<br></b><b>Solid programming experience (C#)<br></b><b>QA Engineer experience</b>

<h4><u>Schedule</u></h4>


{| class="wikitable" border="1" style="text-align:left"<br>
|-<br>
! Task<br>
! Start Time<br>
! End Time<br>
! Owner<br>
|-<br>
| Design test plan<br>
| Apr.<br>
| Apr.<br>
| Stephen &<br>
|-<br>
|<br>
| Apr.<br>
| Apr.<br>
|<br>
|-<br>
|<br>
| Apr.<br>
| Apr.<br>
|<br>
|-<br>
|<br>
| Apr.<br>
| Apr.<br>
|<br>
|-<br>
|<br>
| Apr.<br>
| Apr.<br>
|<br>
|-<br>
|}<br>
<h4><u>Risks and contingencies</u></h4>
''Any activity that jeopardizes the testing schedule is a planning risk''<br>
<b>Program release schedule delay will jeopardizes testing schedule<br></b> Program quality of release version couldn't satisfy with acceptance criteria<br>
<b>Test environmental stuff unobtainable easily<br></b> Delays in necessary QA training (e.g., understanding what needs to be tested, writing sample applications, test tools, and automation scripts)<br>
<b>Tester staff change or lack of tester resources<br></b> Changes to the original requirements or Designs<br>
<b>Frequent program design changes</b>

<h4><u>Approvals</u></h4>

''Persons who declare that the software is ready to move to the next stage''<br>
<br>
User 1<br>
User 2<br>
User 3<br>