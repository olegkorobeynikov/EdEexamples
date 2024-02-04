**Order:**

### Default:

```
2024-02-04 21:01:11.5553[Info ][TestsFixture1.cs:48 ] Fixture - TestCaseCreator 
2024-02-04 21:01:12.2375[Info ][TestsFixture1.cs:48 ] Fixture - TestCaseCreator 
2024-02-04 21:01:12.3455[Info ][SetUpFixture.cs:13 ] SetUpFixture - Constructor 
2024-02-04 21:01:12.3467[Info ][SetUpFixture.cs:19 ] SetUpFixture - OneTimeSetUp 
2024-02-04 21:01:12.3467[Info ][TestBase.cs    :11 ] Base - Constructor 
2024-02-04 21:01:12.3467[Info ][TestsFixture1.cs:7  ] Fixture - Constructor 
2024-02-04 21:01:12.3467[Info ][TestBase.cs    :17 ] Base - OneTimeSetUp 
2024-02-04 21:01:12.3467[Info ][TestsFixture1.cs:13 ] Fixture - new OneTimeSetUp 
2024-02-04 21:01:12.3467[Info ][TestBase.cs    :23 ] Base - SetUp 
2024-02-04 21:01:12.3467[Info ][TestsFixture1.cs:19 ] Fixture - new SetUp 
2024-02-04 21:01:12.3467[Info ][TestsFixture1.cs:37 ] Fixture - Test1 
2024-02-04 21:01:12.3467[Info ][TestsFixture1.cs:31 ] Fixture - new TearDown 
2024-02-04 21:01:12.3467[Info ][TestBase.cs    :35 ] Base - TearDown 
2024-02-04 21:01:12.3467[Info ][TestBase.cs    :23 ] Base - SetUp 
2024-02-04 21:01:12.3467[Info ][TestsFixture1.cs:19 ] Fixture - new SetUp 
2024-02-04 21:01:12.3467[Info ][TestsFixture1.cs:43 ] Fixture - Test2 - case1 
2024-02-04 21:01:12.3467[Info ][TestsFixture1.cs:31 ] Fixture - new TearDown 
2024-02-04 21:01:12.3467[Info ][TestBase.cs    :35 ] Base - TearDown 
2024-02-04 21:01:12.3467[Info ][TestBase.cs    :23 ] Base - SetUp 
2024-02-04 21:01:12.3467[Info ][TestsFixture1.cs:19 ] Fixture - new SetUp 
2024-02-04 21:01:12.3467[Info ][TestsFixture1.cs:43 ] Fixture - Test2 - case2 
2024-02-04 21:01:12.3467[Info ][TestsFixture1.cs:31 ] Fixture - new TearDown 
2024-02-04 21:01:12.3467[Info ][TestBase.cs    :35 ] Base - TearDown 
2024-02-04 21:01:12.3467[Info ][TestsFixture1.cs:25 ] Fixture - new OneTimeTearDown 
2024-02-04 21:01:12.3467[Info ][TestBase.cs    :29 ] Base - OneTimeTearDown 
2024-02-04 21:01:12.3467[Info ][SetUpFixture.cs:25 ] SetUpFixture - OneTimeTearDown 
```

### When [assembly: FixtureLifeCycle(LifeCycle.InstancePerTestCase)]:
```
2024-02-04 22:53:30.3992[Info ][TestsFixture1.cs:50 ] Fixture - TestCaseCreator 
2024-02-04 22:53:31.2403[Info ][TestsFixture1.cs:50 ] Fixture - TestCaseCreator 
2024-02-04 22:53:31.3829[Info ][SetUpFixture.cs:13 ] SetUpFixture - Constructor 
2024-02-04 22:53:31.3829[Info ][SetUpFixture.cs:19 ] SetUpFixture - OneTimeSetUp 
2024-02-04 22:53:31.3829[Info ][TestBase.cs    :17 ] Base - OneTimeSetUp 
2024-02-04 22:53:31.3829[Info ][TestsFixture1.cs:15 ] Fixture - new OneTimeSetUp 
2024-02-04 22:53:31.3829[Info ][TestBase.cs    :11 ] Base - Constructor 
2024-02-04 22:53:31.3829[Info ][TestsFixture1.cs:9  ] Fixture - Constructor 
2024-02-04 22:53:31.3829[Info ][TestBase.cs    :23 ] Base - SetUp 
2024-02-04 22:53:31.3829[Info ][TestsFixture1.cs:21 ] Fixture - new SetUp 
2024-02-04 22:53:31.3829[Info ][TestsFixture1.cs:39 ] Fixture - Test1 
2024-02-04 22:53:31.3829[Info ][TestsFixture1.cs:33 ] Fixture - new TearDown 
2024-02-04 22:53:31.3829[Info ][TestBase.cs    :35 ] Base - TearDown 
2024-02-04 22:53:31.3933[Info ][TestBase.cs    :11 ] Base - Constructor 
2024-02-04 22:53:31.3933[Info ][TestsFixture1.cs:9  ] Fixture - Constructor 
2024-02-04 22:53:31.3933[Info ][TestBase.cs    :23 ] Base - SetUp 
2024-02-04 22:53:31.3933[Info ][TestsFixture1.cs:21 ] Fixture - new SetUp 
2024-02-04 22:53:31.3933[Info ][TestsFixture1.cs:45 ] Fixture - Test2 - case1 
2024-02-04 22:53:31.3933[Info ][TestsFixture1.cs:33 ] Fixture - new TearDown 
2024-02-04 22:53:31.3933[Info ][TestBase.cs    :35 ] Base - TearDown 
2024-02-04 22:53:31.3933[Info ][TestBase.cs    :11 ] Base - Constructor 
2024-02-04 22:53:31.3933[Info ][TestsFixture1.cs:9  ] Fixture - Constructor 
2024-02-04 22:53:31.3933[Info ][TestBase.cs    :23 ] Base - SetUp 
2024-02-04 22:53:31.3933[Info ][TestsFixture1.cs:21 ] Fixture - new SetUp 
2024-02-04 22:53:31.3933[Info ][TestsFixture1.cs:45 ] Fixture - Test2 - case2 
2024-02-04 22:53:31.3933[Info ][TestsFixture1.cs:33 ] Fixture - new TearDown 
2024-02-04 22:53:31.3933[Info ][TestBase.cs    :35 ] Base - TearDown 
2024-02-04 22:53:31.3933[Info ][TestsFixture1.cs:27 ] Fixture - new OneTimeTearDown 
2024-02-04 22:53:31.3933[Info ][TestBase.cs    :29 ] Base - OneTimeTearDown 
2024-02-04 22:53:31.3933[Info ][SetUpFixture.cs:25 ] SetUpFixture - OneTimeTearDown 
```