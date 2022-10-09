# Test-Assignment-2

## 1 Reflections

**1.1 Computer Mouse**

•  Verify whether or not the mouse is optical. 

•  Check to see if the left and right click buttons are functioning properly. 

•  Verify that the double click is functioning properly. 

•  In order to count as a double click, ensure there is sufficient time between two left clicks. 

•  Verify whether or not the scroller is present at the top. 

•  Verify the speed of the mouse pointer.

•  Check the pressure necessary to press the mouse buttons. 

•  Verify the acceleration of the mouse pointer.

•  Check to see whether using the mouse to click and drag works as intended (drag and drop functionality). 

•  Verify the mouse's size to see if it is comfortable to hold and use. 

•  Make that the mouse functions on each of the permitted surfaces. 

•  Verify whether the mouse is tethered or wireless. 

•  Check the range at which a wireless mouse is still functional in this scenario. 

•  Check the battery needs of the mouse if it is a wireless model. 

•  Inspect to see if a mouse or switch is available. 

**1.2 Catastrophic failure**

Because NASA's ozone layer mapping project's data analysis software was built to reject readings that differed significantly from expected measurements, the hole in the ozone layer above Antarctica went unnoticed for a long time. It wouldn't have been a problem if they had evaluated the data analysis to see if it ignored values. 

The project had been started in 1978, but it wasn't until 1985—and not by NASA—that the hole was found. After reviewing their data, NASA discovered the inaccuracy; this confirmed that there was a significant hole in the ozone layer. 

## Two Katas

[2.1 String Utility](https://github.com/Benjo6/Test-Assignment-2/blob/master/BDD/Features/StringUtility.feature)

Tests:

• Test Lowercase String

• Test Uppercase String

• Test Reverse String

[2.2 Bowling Game Kata](https://github.com/Benjo6/Test-Assignment-2/blob/master/BDD/Features/Bowling.feature)

Tests:

• Test Gutter Game

• Test All Ones

• Test One Spare

• Test One Strike

• Test Perfect Game

## Investigation of Tools
**3.1 Junit5**

@Tag is a repeatable annotation that is used to declare a tag for the annotated test class or test method. 
For a specific test plan, tags are used to filter which tests are run.For instance, a development team might tag tests with descriptors like "quick," "slow," and other terms before providing a list of tags to be applied to the current test plan, sometimes depending on the environment. 

@Disabled is an annotation can be used to exclude the test methods from the test suite. Both a test class and a single test method may be affected by this annotation.

@RepeatedTest is used to signal that the annotated method is a test template method that should be repeated a specified number of times with a configurable display name.

@BeforeEach annotation is used to signal that the annotated method should be executed before each invocation of @Test, @RepeatedTest, @ParameterizedTest, or @TestFactory method in the current class. While @afterEach is the exact opposite it signals that the annotated method should be executed after.

@BeforeAll is used to signal that the annotated method should be executed before all tests in the current test class.

@AfterAll is used to signal that the annotated method should be executed after all tests in the current test class.

@Nested is used to signal that the annotated class is a nested, non-static test class (i.e., an inner class) that can share setup and state with an instance of its enclosing class. 

assumeFalse = If the condition in assumeFalse is false then only the rest of the test method is executed, else the test is skipped.

assumeTrue = If the condition in assumeTrue is true then only the rest of the test method is executed, else the test is skipped.

**3.2 Mocking Frameworks**

*What are their similarities (Mockito and Moq)?*
They are both testing frameworks tools which are used to generate replacement objects like Stubs and Mocks.

*What are their differences?*
Moq: It is a mocking library for.NET created from the ground up to fully utilize lambda expressions and.NET Linq expression trees. This makes it possible to use a mocking library that is type-safe and refactoring-friendly. Along with classes, it also supports mimicking interfaces. 

Mockito: It is a framework for mocking. With a clear and straightforward API, it enables you to create attractive tests. The tests are quite understandable and they result in clean verification failures, so you don't have a hangover. 

*Which one would you prefer, if any and why.*

I personally like the Moq better due it being C#. I still think Mockito gives a better layout for the coder.
