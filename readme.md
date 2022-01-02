# Create a program to generate items from 1 to 100.

## Business Rules:
### Every multiple of 3 must has the Fizz value
### and every multiple of 5 must be Buzz
### Create Unit tests for the program.

## Refator the test to use some SOLID principles:

### **SRP - Single Responsability Principle:** New the FizzBuzz class has a unique responsabilty of return a parametrized number of elements. There is a new factory class that contains the business rule and fabricate an specific child of the Abstract Generator class.

### **OCP - Open/Close Principle:** An abstract class establishes a fix contract, that cannot be modified, which receives the current position and will delegate the GetElement result to children implementation. Children might receive changes in the future, but without affect the root contract. The main program uses these root contract, so the application will be Closed to modification but Opent to extension.

### **LSP - Liskov Substitute Principle:** as we can see through the GeneratorFactory class, children classes are replacing the AbsElementGenerator to GetElement without any problem.

### **ISP - Interface Segregation Principle:** the interfaces must be speciallized, not too big, not comprehensive, but fully dedicated to attend the use cases and not force some program implement rules that it doesn't need. This principle cannot be seemed in this program, because it is too simple at current stage and the interface represented by the AbsElementGenerator itself is already dedicated.

### **DSP - Dependency Inversion Principle:** Both low level classes (in here, those that generates the element NumberGenerator, FizzGenerator, BuzzGenerator, FizzBuzzGenerator) and the high level classe FizzBuzz, all of them depend on an abstraction (AbsElementGenerator). Therefore, they are loosely couple between themselves. The high level class will be able to generate each elements without any knowing about how this element is generated. At the same time, the low level classes have a single responsability to generate an element, idependent of how and when it will be used.

> **Created by:** Daniel Melo - Warrington, UK - January 2nd, 2022