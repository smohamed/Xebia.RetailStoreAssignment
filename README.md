# Xebia.RetailStoreAssignment

Because of the trivial and simple requirements and the very limited time I have (I won't be able to work on this assignment through the next 10 days as I'm starting a short vacation this Wednesday), 
I have decided to do 3 different implementations with varied design decisions. 

You can find these design options in 3 different branches in this github repo.

Below are some assumptions I have made:
- It was not clear what precedence the percentage based discounts should follow, so I'd assumed it's in the same order you mentioned them in the email (employee -> affiliate -> customer).
- It was not clear if the $100 discount should be applied before or after the percentage discount, I'm assuming the later (applied on the final amount after percentage discounts).
- It was not clear how should I calculate how long the user have been a customer, I'll base it on the user joining date.

Anyway, please note I have did this in very short time. Also, being just an assignment it's really very tough to decide on core design decisions (performance, scalability, security, error handling, etc.). 

Please take into your consideration that if I was solving this issue on a production system I'd probably taken very different approach based on the full system requirements/expectations as well as time considerations and budget, etc.

Finally, I hope these options I have provided can give enough insights to help you reach a definitive opinion and come to a conclusion ASAP.

Now, for building and running the solution:
- I have built the solution using Visual Studio 2017 (unfortunately I only have this version currently installed on my machine) but I didn't use any features that's not found on previous versions. 
So, I suppose you can use any VS version to build and run it (VS 2012+ is recommended).
- The target runtime version is .NET Framework 4.5.2, so you need this version installed on the target machine.
- The test project (Xebia.RetailStore.Tests) is using xUnit.net testing framework version 2.2.0 which is installed through NuGet. 
Once you build the solution for the first time, the build engine should download and install the required NuGet libraries automatically.
- The solution consists of just 2 class libraries, their details as follows:
	o	Xebia.RetailStore, the main project where the core logic is implemented. I have opted for ClassLib project type as I decided not to implement any client code as I think the tests cover all the scenarios and it's very simple to follow them and understand the code easily as I have kept it very simple and straight forward.
	o	Xebia.RetailStore.Tests, again this just a ClassLib project type that have xUnit.net installed atop of it to provide the testing functionality.
- Upon building the solution in VS just open the 'Test Explorer' view from the 'Test' menu.
- From the Test Explorer window, you can just run all the tests to make sure all are green.
- I have added a total of 15 test methods to test 15 different scenarios. Please feel free to add more if you got any extra one you want to test.
- For test coverage, you need can get the coverage result from inside VS using 'Test' menu then 'Windows' then 'Test Coverage Results'.

Regards,
ElSayed    