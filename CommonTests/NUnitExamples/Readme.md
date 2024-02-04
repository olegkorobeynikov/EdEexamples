**PassingFixtureParameter:**

The importance is hidden in the parameter - FixtureLifeCycle.<br>
Note how the order of method calls is changed and how parameters are passed.


#### [FixtureLifeCycle(LifeCycle.SingleInstance)] (default)
```
2024-02-04 22:43:02.8670[Info ][PassingFixtureParameter.cs:17 ] Constructor = Type1 
2024-02-04 22:43:02.8670[Info ][PassingFixtureParameter.cs:24 ] OneTimeSetUp = Type1 
2024-02-04 22:43:02.8670[Info ][PassingFixtureParameter.cs:30 ] Test = Type1 
2024-02-04 22:43:02.8670[Info ][PassingFixtureParameter.cs:17 ] Constructor = Type2 
2024-02-04 22:43:02.8670[Info ][PassingFixtureParameter.cs:24 ] OneTimeSetUp = Type2 
2024-02-04 22:43:02.8670[Info ][PassingFixtureParameter.cs:30 ] Test = Type2 
2024-02-04 22:43:02.8670[Info ][PassingFixtureParameter.cs:17 ] Constructor = Type3 
2024-02-04 22:43:02.8670[Info ][PassingFixtureParameter.cs:24 ] OneTimeSetUp = Type3 
2024-02-04 22:43:02.8670[Info ][PassingFixtureParameter.cs:30 ] Test = Type3 
```

#### [FixtureLifeCycle(LifeCycle.InstancePerTestCase)]

```
2024-02-04 22:43:18.5479[Info ][PassingFixtureParameter.cs:53 ] OneTimeSetUp = None 
2024-02-04 22:43:18.5518[Info ][PassingFixtureParameter.cs:46 ] Constructor = Type1 
2024-02-04 22:43:18.5518[Info ][PassingFixtureParameter.cs:59 ] Test = Type1 
2024-02-04 22:43:18.5518[Info ][PassingFixtureParameter.cs:53 ] OneTimeSetUp = Type1 
2024-02-04 22:43:18.5518[Info ][PassingFixtureParameter.cs:46 ] Constructor = Type2 
2024-02-04 22:43:18.5518[Info ][PassingFixtureParameter.cs:59 ] Test = Type2 
2024-02-04 22:43:18.5518[Info ][PassingFixtureParameter.cs:53 ] OneTimeSetUp = Type2 
2024-02-04 22:43:18.5518[Info ][PassingFixtureParameter.cs:46 ] Constructor = Type3 
2024-02-04 22:43:18.5518[Info ][PassingFixtureParameter.cs:59 ] Test = Type3 
```