# Judo .NET SDK

<a href="https://scan.coverity.com/projects/judopaydotnetsdk">
  <img alt="Coverity Scan Build Status"
       src="https://img.shields.io/coverity/scan/6752.svg"/>
</a>

The .NET SDK is a client for our Judopay API, which provides card payment processing for mobile apps and websites.

##### **\*\*\*Due to industry-wide security updates, versions below 1.1.113 of this SDK will no longer be supported after 1st Oct 2016. For more information regarding these updates, please read our blog [here](http://hub.judopay.com/pci31-security-updates/).*****

## Requirements

## Getting started
The Judopay SDK is distributed as a [NuGet package](https://www.nuget.org/packages/JudoPay.Net/) 
using the package name of JudoPay.Net.

####1. Integration
You can install the SDK directly from within Visual Studio either using the NuGet package manager UI, or in the Package Manager Console:

```powershell
Install-Package JudoPay.Net
```

####2. Setup

You configure you Judopay API client when invoking the JudoPaymentsFactory.Create method. This has
three parameters; environment (Sandbox for development and testing, and Live for production), and api
token and secret. You set you API token and secret up through our [management dashboard](https://portal.judopay.com)
after creating an account. You can create a testing account by clicking "Getting Started" in our [documentation](https://www.judopay.com/docs)

```c#
var client = JudoPaymentsFactory.Create(JudoPayDotNet.Enums.JudoEnvironment.Sandbox, "<TOKEN>", "<SECRET>");
```

####3. Make a payment
Once you have your API client, you can easily process a payment:

```c#
var cardPaymentModel = new CardPaymentModel
{
	JudoId = "<JUDO_ID>",

	// value of the payment
	Amount = 1.01m,
	Currency = "GBP",

	// card details
	CardNumber = "4976000000000036",
	ExpiryDate = "1215",
	CV2 = "452",

	// an identifier for your customer
	YourConsumerReference = "MyCustomer004",
};
```
**Note:** Please make sure that you are using a unique Consumer Reference for each different consumer.

####4. Check the payment result
```
client.Payments.Create(cardPaymentModel).ContinueWith(result =>
{
	var paymentResult = result.Result;

	if (!paymentResult.HasError && paymentResult.Response.Result == "Success")
	{
		Console.WriteLine("Payment successful. Transaction Reference {0}", paymentResult.Response.ReceiptId);
	}

});
```

## Next steps
The Judo .NET library supports additional features and a range of customization options. For more information about this SDK see our wiki documentation as well as our public documentation.
