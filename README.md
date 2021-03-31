# Exercise 1
Having as a starting point the picture below, describe in free text how you would test the “Open” functionality provided by Microsoft Word. 
Make sure to call out precise things (e.g: click, double click, typing, open, not open…) that you do in your verification.  
Please use a table like the one provided below to organise the test cases you have identified.

TestCase number 1                |  Mouse.Click()
TestCase number 2                |  Keyboard.Presskey()

Tip: Use a real session of Microsoft Word to explore the UI controllers that it offers.

# Exercise 2
# Today's Exchange Rate
Our company is looking to provide the best exchange rate to its customers.
## Requirements
We want to find out what is today's USD - EUR best exchange rate, using various sources, and display it to the user in a way that is suitable for the user.
Please implement as many steps as you can from the requirements below, ideally covering all the work by unit/integration tests.
### Steps
1. Extract the value of the `USDEUR` property from the following JSON string:
```json
{
    "success": true,
    "terms": "https:\/\/currencylayer.com\/terms",
    "privacy": "https:\/\/currencylayer.com\/privacy",
    "timestamp": 1507639147,
    "source": "USD",
    "quotes":
        {
        //...
        "USDETB": 23.410168,
        "USDEUR": 0.847802,
        "USDFJD": 2.052013,
        "USDFKP": 0.757298
        //...
    }
}
```
(in this case, the result is `0.847802`)

2. Extract the value of the `EUR` property from the following JSON string:
```json
{
    "disclaimer": "Usage subject to terms: https://openexchangerates.org/terms",
    "license": "https://openexchangerates.org/license",
    "timestamp": 1507640400,
    "base": "USD",
    "rates": 
    {
        //...
        "ETB": 23.66,
        "EUR": 0.848383,
        "FJD": 2.056501,
        "FKP": 0.758728,
        "GBP": 0.758728,
        "GEL": 2.475408,
        "GGP": 0.758728
        //...
    }
}
```
(in this case, the result is `0.848383`)

3. Compare the 2 values obtained above, printing the smallest one:
In the App.config file, we have a key in the app settings section named `PrintMode` that specifies the output method:
    • when this key has the value `Console`, we want to print out the result in the console window.
    • when this key has the value `MessageBox`, we want to write the result in a new message box.

4. Obtain and use the live version of the first JSON from:
 http://api.currencylayer.com/live?access_key=ca2efa55a751808737f72d415f1ca387 
5. Obtain and use the live version of the second JSON from:
 https://openexchangerates.org/api/latest.json?app_id=1de86dfd996b4c9da20c0b3fa6eefaa4&base=USD
6. For the case when the internet connection is slow, we want to modify the code to not keep threads blocked while we get the content from the web.

## Expectations
Write this code the best way you can, as it would be production code.
While we are interested in the solution itself, we also want to understand how you approach the problem and what you are taking into consideration 
when building the solution (i.e. readability, extensibility, robustness, testability, etc.). Ideally, we want to be able to change the exchange rate 
provider later without affecting the business of the application.
