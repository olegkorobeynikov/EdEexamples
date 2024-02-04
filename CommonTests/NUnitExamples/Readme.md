**PassingFixtureParameter:**

You can pass parameters through the fixture by taking a parameter in the constructor, but this will all work in unexpected ways if you use a non-default value in the FixtureLifeCycle attribute. The logs below shows how the order of method calls is changed and how parameters are passed.


#### [FixtureLifeCycle(LifeCycle.SingleInstance)] (default)
```
[PassingFixtureParameter.cs:17 ] Constructor = Type1 
[PassingFixtureParameter.cs:24 ] OneTimeSetUp = Type1 
[PassingFixtureParameter.cs:30 ] Test = Type1 
[PassingFixtureParameter.cs:17 ] Constructor = Type2 
[PassingFixtureParameter.cs:24 ] OneTimeSetUp = Type2 
[PassingFixtureParameter.cs:30 ] Test = Type2 
[PassingFixtureParameter.cs:17 ] Constructor = Type3 
[PassingFixtureParameter.cs:24 ] OneTimeSetUp = Type3 
[PassingFixtureParameter.cs:30 ] Test = Type3 
```

#### [FixtureLifeCycle(LifeCycle.InstancePerTestCase)]

```
[PassingFixtureParameter.cs:53 ] OneTimeSetUp = None 
[PassingFixtureParameter.cs:46 ] Constructor = Type1 
[PassingFixtureParameter.cs:59 ] Test = Type1 
[PassingFixtureParameter.cs:53 ] OneTimeSetUp = Type1 
[PassingFixtureParameter.cs:46 ] Constructor = Type2 
[PassingFixtureParameter.cs:59 ] Test = Type2 
[PassingFixtureParameter.cs:53 ] OneTimeSetUp = Type2 
[PassingFixtureParameter.cs:46 ] Constructor = Type3 
[PassingFixtureParameter.cs:59 ] Test = Type3 
```