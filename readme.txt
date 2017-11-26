Running .NET Core 2.0.0 tests for framework netcoreapp2.0...
xUnit.net Console Runner (64-bit .NET Core 4.6.00001.0)
  Discovering: xunit-issue
  Discovered:  xunit-issue
  Starting:    xunit-issue
    xunit_issue.Sqltest.should_connect [FAIL]
      Assert.Throws() Failure
      Expected: typeof(System.InvalidOperationException)
      Actual:   typeof(System.PlatformNotSupportedException): System.Data.SqlClient is not supported on this platform.
      Stack Trace:
           at System.Data.SqlClient.SqlConnection..ctor()
        /Users/andrea/dev/xunit-issue/Sqltest.cs(14,0): at xunit_issue.Sqltest.<>c.<should_connect>b__0_0()
  Finished:    xunit-issue
=== TEST EXECUTION SUMMARY ===
   xunit-issue  Total: 1, Errors: 0, Failed: 1, Skipped: 0, Time: 0,271s