/*
// Encapsulation

using ConsoleApp1.src.OopPrinciples.Encapsulation;

BankAccount  bankAccount = new BankAccount(100);

System.Console.WriteLine(bankAccount.GetBalance());

bankAccount.Deposit(50);
System.Console.WriteLine(bankAccount.GetBalance());

bankAccount.WithDraw(200);
System.Console.WriteLine(bankAccount.GetBalance());
*/

/*
// Abstraction

// Reduce complexity by hiding unnecessary details

using ConsoleApp1.src.OopPrinciples.Abstraction;

EmailService emailService = new EmailService();
emailService.SendEmail();
*/


/*
//Inheritance 

using ConsoleApp1.src.OopPrinciples.Inheritance;

var car = new Car();

// Shared

car.Brand = "Ford";
car.Start();
car.Stop();

// Unique
car.NumberOfDoors = 4;
*/

/*
//Polymorphism

// Polymorphism is the ability of an object to take many forms.

using ConsoleApp1.src.OopPrinciples.Polymorphism;

List<Vehicule> vehicules = new List<Vehicule>();
vehicules.Add(new Car { Brand= "Toyota", Model = "Camry", Year = 2020, NumberOfDoors = 4});
vehicules.Add(new Motorcycle { Brand = "Harley Davidson", Model = "Sportster", Year = 2021 });

// Vehicule inspection
foreach(var vehicule in vehicules)
{
    vehicule.Start();
}
*/

/*
//Coupling 

// The degree of dependency between different classes

using ConsoleApp1.src.OopPrinciples.Coupling;

var order = new Order(new SmsSender());
// EmailSender implements INotification interface, it means that each instance of EmailSender is also an instance of INotificationService
order.PlaceOrder();
*/


// Composition

// Composition involves creating complex objects by combining simpler objects or components. In composition, objects are assembled together to
// form larger structures, with each component object maintaining its own state and behavior. Composition is often described in terms of a "has-a" 
// relationship

/*
using ConsoleApp1.src.OopPrinciples.Composition;

var car = new Car();

car.StartCar();
*/

// Composition vs Inheritance 

// When to use Composition:

// When you need flexibility in constructing objects by asembling smaller, reusable components.
// When there is no clear "is-a" relationship between classes, and a "has-a" relationship is more appropriate.
// When you want to avoid the limitations of inheritance, such as tight coupling and the fragile base class problem
// which we will look into shortly.

// When to use Inheritance:

// When there is a clear "is-a" relationship between classes, and subclass objects can be treated as instances of their superclass.
// When you want to promote code reuse by inheriting properties and behaviors from existing classes.
// When you want to leverage polymorphism to allow objects of different subclasses to be treated uniformaly through their common superclass
// interface.

// Fragile Base Class Problem and why you should use composition over inheritance

// The Fragile Base Class Problem is a software design issue that arises in object-oriented programming when changes made to a base class 
//can inadvertently break the functionality of derived classes. This problem occurs due to the tight coupling between base and derived classes 
// in inheritance hierachies.

// 1. Inheritance Coupling : Inheritance creates a strong coupling between the base class (superclass) and derived classes (subclasses). 
//Any changes made to the base class can potentially affect the behavior of all derived classes.

// 2. Limited Extensibility : The Fragile Base Class Problem limits the extensibility of software systems, as modifications to the base class
// can become increasingly risky and costly over time. Developers may avoid making necessary changes due to the fear of breaking existing functionality

// Mitigation Strategies : To mitigate the Fragile Base Class Problem, software developers can use design principles such as the Open/CLosed Principle (OCP)
// and Dependency Inversion Principle (DIP), as well as design patterns like Composition over Inheritance. These approaches promote loose coupling, encapsulation
// and modular design, reducing th eimpact of changes in base classes.

// **************SOLID************************ //

// Single Responsability Principle (SRP)

// A class should have only one reason to change, meaning that it should have only one responsability or purpose

// Open/Closed Principle (OCP)

// Software entities (classes, modules, functions, etc.) should be open for extension but closed for modification

// Liskov Substitution Principle (LSP)

// Objects of a superclass should be replaceable with objects of its subclass without affecting the correctness of the program


// If we substitutes the Rectangle (superclass) with Square (subclass), the program should gives us the same result
/*
using First_project.src.SOLID.L;
Shape rectangle = new Rectangle { Width = 5, Height = 4 };
System.Console.WriteLine($"Area of the rectangle: {rectangle.Area}");

Shape square = new Square { SideLength = 5 };
System.Console.WriteLine($"Area of the square: {square.Area}");
*/

/*
// Interface Segregration Principle (ISP):

// Clients should not be forced to depend on interfaces they do not use

using First_project.src.SOLID.I;

var circle = new Circle();

circle.Radius = 10;

System.Console.WriteLine(circle.Area());
*/


/*
// Dependency Inversion principle (DIP):

// High-level modules should not depend on low-level modules. Both should depend on abstractions.

using First_project.src.SOLID.D;

Car car = new Car(new Engine());
*/

// Design Patterns

// There are three main groups of design pattenrs:

// - Creational: the different ways to create objects
// - Structural: the relationships between those objects
// - Behavioral: the interaction or communication between those objects

// Behavioral Design Pattern 

// Behavioral design pattern focus on how objects interact with each other and how they communicate to accomplish specific tasks. 
//These patterns address communication, responsability, and algorithmic issues in object-oriented software design. 
// They help in defining clear and efficient communication mechanisms between objects and classes.

// These patterns help in making the design moe flexible, extensible, and maintainable by promoting better communication 
// and separation of conerns between objects and classes in the system. Each pattern addresses specific design issues 
// and provide a standardized solution to common problems encountered in software development.


// Observer Pattern :

// It involves an object, known as the subject, maintaining a list of its dependent objects, called observers, and notifying them automatically
// of any state changes

// Strategy Pattern:

// Th Strategy Pattern is used to pass different algorithms, or behaviors, to an object.

// First, let's consider an application that stores videos. Before storing a video, the video needs to be compressed using specific compression algorithm,
// such as MOV or MP4, if necessary, apply an overlay to the video, such as black and white or blur.


using First_project.src.DesignPatterns.Behavioral.Strategy.GoodExample;

var videoStorage = new VideoStorage(new CompressorMOV(), new OverlayBlackAndWhite());

videoStorage.Store("/videos/some-movie");

videoStorage.SetCompressor(new CompressorMP4());
videoStorage.SetOverlay(new OverlayNone());

videoStorage.Store("/videos/some-movie");