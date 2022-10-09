# Test-Assignment-2

## 1 Reflections

**1.1 Computer Mouse**

•  Check if the mouse is an optical mouse or not.
•  Verify that left-click and right-click buttons are working fine.
•  Check if the double click is working fine.
•  Verify the time duration between two left clicks, in order to consider it as a double click.
•  Check if the scroller is present at the top or not.
•  Verify the speed of the mouse pointer.
•  Check the pressure required for clicking the mouse buttons.
•  Verify the acceleration of the mouse pointer.
•  Verify that clicking the button and dragging the mouse operation is working fine(drag and drop functionality).
•  Check the dimension of the mouse, if it’s suitable to grip and work.
•  Verify that the mouse works in all the allowed surfaces.
•  Check if the mouse is a wireless mouse or corded mouse.
•  In the case of wireless mouse, check the range up to which the mouse remains operational.
•  In the case of a wireless mouse, check the battery requirement of the mouse.
•  Check if there is an option to switch on or mouse.

**1.2 Catastrophic failure**

The hole in the ozone layer over Antarctica remained undetected for a long period of time because the data analysis software used by NASA in its project to map the ozone layer had been designed to ignore values that deviated greatly from expected measurements. They could easily have tested the data analysis if it ignored values, and this wouldn’t have been a problem.
The project had been launched in 1978, but it wasn’t until 1985 that the hole was discovered, and not by NASA. NASA didn’t find the error until they reviewed their data, which indeed showed that there was a big hole in the ozone layer.

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
Tags are used to filter which tests are executed for a given test plan. For example, a development team may tag tests with values such as "fast", "slow", "ci-server", etc. and then supply a list of tags to be used for the current test plan, potentially dependent on the current environment. 

@Disabled is an annotation can be used to exclude the test methods from the test suite. This annotation can be applied over a test class as well as over individual test methods.

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
Moq: It is a mocking library for .NET developed from scratch to take full advantage of .NET Linq expression trees and lambda expressions. This makes it type-safe and refactoring-friendly mocking library available. And it supports mocking interfaces as well as classes.
Mockito: It is a mocking framework. It lets you write beautiful tests with a clean & simple API. It doesn’t give you hangover because the tests are very readable and they produce clean verification errors.

*Which one would you prefer, if any and why.*

I personally like the Moq better due it being C#. I still think Mockito gives a better layout for the coder.
