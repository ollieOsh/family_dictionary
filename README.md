# The Family Dictionary

## Instructions

1. Define a Dictionary that contains information about several members of your family. Use the following example as a template.

    ```cs
    Dictionary<string, Dictionary<string, string>> myFamily = new Dictionary<string, Dictionary<string, string>>();

    myFamily.Add("sister", new Dictionary<string, string>(){ 
        {"name", "Krista"},
        {"age", "42"}
    });
    ```
2. Next, iterate over each item in `myFamily` and produce the following output.
    ```
    Krista is my sister and is 42 years old
    ```