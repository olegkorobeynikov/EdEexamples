**Order:**

### Default:

```
[TestsFixture1.cs:48 ] Fixture - TestCaseCreator 
[TestsFixture1.cs:48 ] Fixture - TestCaseCreator 
[SetUpFixture.cs:13 ] SetUpFixture - Constructor 
[SetUpFixture.cs:19 ] SetUpFixture - OneTimeSetUp 
[TestBase.cs    :11 ] Base - Constructor 
[TestsFixture1.cs:7  ] Fixture - Constructor 
[TestBase.cs    :17 ] Base - OneTimeSetUp 
[TestsFixture1.cs:13 ] Fixture - new OneTimeSetUp 
[TestBase.cs    :23 ] Base - SetUp 
[TestsFixture1.cs:19 ] Fixture - new SetUp 
[TestsFixture1.cs:37 ] Fixture - Test1 
[TestsFixture1.cs:31 ] Fixture - new TearDown 
[TestBase.cs    :35 ] Base - TearDown 
[TestBase.cs    :23 ] Base - SetUp 
[TestsFixture1.cs:19 ] Fixture - new SetUp 
[TestsFixture1.cs:43 ] Fixture - Test2 - case1 
[TestsFixture1.cs:31 ] Fixture - new TearDown 
[TestBase.cs    :35 ] Base - TearDown 
[TestBase.cs    :23 ] Base - SetUp 
[TestsFixture1.cs:19 ] Fixture - new SetUp 
[TestsFixture1.cs:43 ] Fixture - Test2 - case2 
[TestsFixture1.cs:31 ] Fixture - new TearDown 
[TestBase.cs    :35 ] Base - TearDown 
[TestsFixture1.cs:25 ] Fixture - new OneTimeTearDown 
[TestBase.cs    :29 ] Base - OneTimeTearDown 
[SetUpFixture.cs:25 ] SetUpFixture - OneTimeTearDown 
```

### When [assembly: FixtureLifeCycle(LifeCycle.InstancePerTestCase)]:
```
[TestsFixture1.cs:50 ] Fixture - TestCaseCreator 
[TestsFixture1.cs:50 ] Fixture - TestCaseCreator 
[SetUpFixture.cs:13 ] SetUpFixture - Constructor 
[SetUpFixture.cs:19 ] SetUpFixture - OneTimeSetUp 
[TestBase.cs    :17 ] Base - OneTimeSetUp 
[TestsFixture1.cs:15 ] Fixture - new OneTimeSetUp 
[TestBase.cs    :11 ] Base - Constructor 
[TestsFixture1.cs:9  ] Fixture - Constructor 
[TestBase.cs    :23 ] Base - SetUp 
[TestsFixture1.cs:21 ] Fixture - new SetUp 
[TestsFixture1.cs:39 ] Fixture - Test1 
[TestsFixture1.cs:33 ] Fixture - new TearDown 
[TestBase.cs    :35 ] Base - TearDown 
[TestBase.cs    :11 ] Base - Constructor 
[TestsFixture1.cs:9  ] Fixture - Constructor 
[TestBase.cs    :23 ] Base - SetUp 
[TestsFixture1.cs:21 ] Fixture - new SetUp 
[TestsFixture1.cs:45 ] Fixture - Test2 - case1 
[TestsFixture1.cs:33 ] Fixture - new TearDown 
[TestBase.cs    :35 ] Base - TearDown 
[TestBase.cs    :11 ] Base - Constructor 
[TestsFixture1.cs:9  ] Fixture - Constructor 
[TestBase.cs    :23 ] Base - SetUp 
[TestsFixture1.cs:21 ] Fixture - new SetUp 
[TestsFixture1.cs:45 ] Fixture - Test2 - case2 
[TestsFixture1.cs:33 ] Fixture - new TearDown 
[TestBase.cs    :35 ] Base - TearDown 
[TestsFixture1.cs:27 ] Fixture - new OneTimeTearDown 
[TestBase.cs    :29 ] Base - OneTimeTearDown 
[SetUpFixture.cs:25 ] SetUpFixture - OneTimeTearDown 
```