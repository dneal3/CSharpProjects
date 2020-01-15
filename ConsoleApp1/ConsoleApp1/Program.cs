using System;
using System.Collections.Generic;


/// C# Naming Conventions
/// Namespace --> Pascal
/// Type --> Pascal
/// Interface --> IPascal
/// Method --> Pascal
/// Property --> Pascal
/// Event --> Pascal
/// Field --> Pascal
/// Enum Value --> Pascal
/// Parameter --> Camel
/// 
/// </summary>

namespace ConsoleApp1
{
    class LearningCSharp   
    {
        class Keywords
        {
            private Dictionary<string, string> keyword_dict = new Dictionary<string, string>();

            public Keywords()
            {
                BuildList();
            }
            public void KeywordList()
            {
                List<string> keywords_li = new List<string>(this.keyword_dict.Keys);
                for(int i=0; i<keywords_li.Count;i++)
                {
                    Console.WriteLine(keywords_li[i]);
                }
            }

            public string FindKeyword(string query)
            {
                try { return keyword_dict[query]; }
                catch (KeyNotFoundException) { return "Keyword not found"; }
                    
            }
            private void BuildList()
            {
                //A Full Dictionary of all the standard keywords in C# and their definitions. Probably not the best way of doing this but it's supposed to be quick and dirty.
                keyword_dict.Add("abstract", "The abstract keyword is a modifier that indicates that the thing being modified has a missing or incomplete implementation. This modifier can be used with " +
                    "classes methods, properties, indexers, and events. Members marked as abstract must be implemented by non-abstract classes that derive from the abstract class");
                keyword_dict.Add("as", "The as operator explicitly converts the result of an expression to a given reference or nullable value type.if it is not possible the as operator returns null." +
                    "The as keyword will never return an exception");
                keyword_dict.Add("base", "The base keyword is used to access members of the base class from within a derived class. There's some kind of fun stuff you can do using constructors by using base()");
                keyword_dict.Add("bool", "The bool type keyword is an alias for the .NET \"System.Boolean\" structure type that represents a Boolean value, which can either be true or false values.");
                keyword_dict.Add("break", "The break statement terminates the closest enclosing loop or switch statement in which it appears. Control is then passed to the statement that follows " +
                    "the terminated statement, if there are any.");
                keyword_dict.Add("byte", "A byte is an integral numeric type, it represents an unsigned 8-byte integer.");
                keyword_dict.Add("case", "A case statement defines a case inside of a switch statement.");
                keyword_dict.Add("catch", "The catch statement is used in a try-catch block. It is used to catch specified, or not specified exceptions, and run a certain block of code when they are caught.");
                keyword_dict.Add("char", "The char keyword is an alias for the \"System.Char\" structure type that represents a unicode UTF-16 character. It can range from U+0000 to U+FFFF and has a size of 16 bits.");
                keyword_dict.Add("checked", "The checked keyword is used to explicitly enable overflow checking for integral-type arithmetic operations and conversions");
                keyword_dict.Add("class", "The class keyword is used to declare a class which is usually in itself an object.");
                keyword_dict.Add("const", "Variables or fields that are declared using the const keyword can be assigned, but after assignment become immutable.");
                keyword_dict.Add("continue", "The continue statement passes control to the next iteration of the enclosing loop statement in which it appears.");
                keyword_dict.Add("decimal", "The decimal keyword denotes a floating-point type number. It differs in the fact that it is very precise, up to 28-29 digits. For this precision the range is" +
                    "from +-1.0*10^-28 -> +-7.9228*10^28 and uses 16 bytes");
                keyword_dict.Add("default", " The default method has two uses, it can be used to specify a default label in the switch statement, or as the default operator or literal to produce the default value.");
                keyword_dict.Add("delagate", "The idea of a delegate function is very similar to that of a function pointer in C++, however delegates are type-safe and secure. These delegates are the basis for events." +
                    "You pass in a method instead of a property or a variable. In method they're very easy to comprehend and there are some very cool things that you can do with them.");
                keyword_dict.Add("do", "The do statement executes a statement or block of statements while a specified boolean expression evaluates to true. a do-while loop will execute one or more times," +
                    " this differs from a while loop which executes zero or more times.");
                keyword_dict.Add("double", "The double keyword denotes a floating-point number. This number takes up 8 bytes and is precise to ~15-17 digits.");
                keyword_dict.Add("else", "This denotes the classic else statement, the code in the else block will run when an if condition is not true.");
                keyword_dict.Add("enum", "An enum type is a value type defined by a set of named constants of the underlying integral numeric type. ");
                keyword_dict.Add("event", "The event keyword is used to declare an event in a publisher class. This is an interesting tool and it has a lot of special properties might be worth " +
                    "looking into a little more.");
                keyword_dict.Add("explicit", "A user-defined type can define a custom implicit or explicit conversion from or to another type.");
                keyword_dict.Add("extern", "The extern modifier is used to declare a method that is implemented externally. A common use of the extern modifier is with the DllImport attribute when one is " +
                    "using Interop services to call into unmanaged code. In this case extern must be declared as static.");
                keyword_dict.Add("false", "The boolean values that represents when a truth statement is not true.");
                keyword_dict.Add("finally", "A finally block allows you to clean up any code used in a try block and the code in a finally block will always be executed even if an exception is raised.");
                keyword_dict.Add("fixed", "The fixed statement prevents the garbage collector from relocating a movable variable. The fixed statement is only permitted in an unsafe context. " +
                    "You can also use the fixed keyword to create fixed size buffers.");
                keyword_dict.Add("float", "The float keyword denotes a floating-point number. It has a precision of ~6-9 digit, and it uses 4 bytes to store the value.");
                keyword_dict.Add("for", "The for statement executes a statement or a block while a specified Boolean expression evaluates to true.");
                keyword_dict.Add("foreach", "The foreach statement executes a statement or a block of statements for each element in an instance of the type that implements the IEnumerable interface" +
                    " the foreach statement is not limited to those types and can be implemented to an instance that has a public parameterless GetEnumerator method whose return type is either a class" +
                    ", struct, or interface type. Or if the return type of GetEnumerator method has the public method \"Current\" property and the public parameterless MoveNext method, so anything" +
                    " that could essentially mimic an iterator can be used with the foreach loop.");
                keyword_dict.Add("goto", "The goto statement transfers control to the related labeled statement, it can be used in switch statements and to get out of deeply nested loops.");
                keyword_dict.Add("if", "The classic if statement, will run a block of code if the boolean expression evaluates to true.");
                keyword_dict.Add("implicit", "Defines an implicit conversion from or to another type.");
                keyword_dict.Add("in", "The in keyword is used in four context: generic type parameters in generic interfaces and delegates. As a parameter modifier, which lets you pass and argument " +
                    "to a method by reference rather than by value.");
                keyword_dict.Add("int", "The int keyword defines a signed 32-bit integer.");
                keyword_dict.Add("interface", "An interface contains only the signatures of methods, properties, events, or indexers. A class that implements the interface must implement the members" +
                    " of the interface that are specified in the interface definition.");
                keyword_dict.Add("internal", "The internal keyword is an access modifier, internal types or members are only accessible within the file in the same assembly.");
                keyword_dict.Add("is", "The is operator checks if the result of an expression is compatible with a given type, or tests an expression (new to 7.0).");
                keyword_dict.Add("lock", "The lock statements acquires the mutual-exclusion lock for a given object, executes a statement block, and then releases the lock. While a lock is held," +
                    " the thread that holds the lock can again acquire it and release the lock. Any other thread is blocked from acquiring the lock and will wait until the lock is released.");
                keyword_dict.Add("long", "The long keyword denotes that a number is a 64-bit signed integer, now that's a huge number!");
                keyword_dict.Add("namespace", "The namespace keyword is used to declare a scope that contains a set of related objects. You can use a namespace to organize code elements and to create globally unique types.");
                keyword_dict.Add("new", "The new operator creates a new instance of a type.");
                keyword_dict.Add("null", "The null keyword is a literal the represents the null reference, one that does not refer to any object. \"null\" is the default value of reference type variables.");
                keyword_dict.Add("object", "The object type is an alias for the \"System.Object\" in .NET. In the unified type system of C#, all types, predefined and user-defined, reference types and value types, " +
                    "inherit directly or indirectly from \"System.Object\". There is a concept called \"Boxing and Unboxing\" associated with this type that is pretty neat.");
                keyword_dict.Add("operator", "A user-defined type can overload a predefined C# operator. That is, a type can provide the custom implementation of an operation in the case one or both operands are" +
                    " of that type. ");
                keyword_dict.Add("out", "The keyword out can be used in two contexts: as a parameter modifier, which lets you pass an argument to a method by reference rather than by value, or in generic type parameter " +
                    "declarations for interfaces and delegates, which specifies that a parameter type is covariant.");
                keyword_dict.Add("override", "The override modifier is required to extend or modify the abstract or virtual implementation of an inherited method, property, indexer, or event.");
                keyword_dict.Add("params", "By using the params keyword you can specify a method parameter that takes a variable number of args. Useful for sending a list of parameters to a method or function.");
                keyword_dict.Add("private", "The keyword private is an access modifier, it provides the least amount of permission. Private members are accessible only within the body of the class or the struct in which " +
                    "they are declared.");
                keyword_dict.Add("protected", "The protected keyword is an access modifier. A protected member can only be used by the class it is within and by derived types of that class.");
                keyword_dict.Add("public", "The public keyword is an access modifier. A public member is accessible by anything, there are no access restrictions.");
                keyword_dict.Add("readonly", "The readonly keyword is a modifier that can be used in four contexts, in a field declaration, readonly indicates that an assignment to the field can only" +
                    " occur as part of the declaration or in a constructor in the same class. A readonly field can't be assigned after a constructor exists. In a readonly struct definition," +
                    " readonly indicates that the struct is immutable. In a readonly member definition, readonly indicates that a member of a struct does not mutate the structs internal state." +
                    " In a ref readonly method return, the readonly modifier indicates that a method returns a reference and writes are not allowed to that reference.(added in 7.2)");
                keyword_dict.Add("ref", "The ref keyword indicates a value that is passed by reference. It is used in four different contexts. In a method signature and in a method call, to pass an argument" +
                    " to a method by reference. In a method signature, to return a value to a caller by reference. In a member body, to indicate that a reference return value is stored locally as a" +
                    " reference that a caller intends to modify or, in general a local variable accesses another value by reference. Lastly, in a struct declaration to declare ref struct or " +
                    "readonly ref struct.");
                keyword_dict.Add("return", "The return statement terminates execution of the method that it is inside of. If a method's return statement is void the return statement can be omitted.");
                keyword_dict.Add("sbyte", "The sbyte keyword represents that a number is a signed 8-bit integer.");
                keyword_dict.Add("sealed", "The sealed modifier when used on a class, prevents other classes from inheriting from it. The sealed keyword on a method or property that overrides a virtual" +
                    " method or property in a base class. This enables you to allow classes to derive from your class and prevent them from overriding specific virtual methods or properties.");
                keyword_dict.Add("short", "The short keyword represents that a number is a signed 16-bit integer.");
                keyword_dict.Add("sizeof", "The sizeof operator returns the number of bytes occupied by a variable of a given type.");
                keyword_dict.Add("stackalloc", "The stackalloc operator allocates a block of memory on the stack. A stack allocated memory block created during the method execution is discarded" +
                    " when the method returns.");
                keyword_dict.Add("static", "The static modifier declares a static member, which belongs to the type itself rather than to a specific object.");
                keyword_dict.Add("string", "The string type represents a sequence of zero or more unicode characters.");
                keyword_dict.Add("struct", "A struct type is a value type that is typically used to encapsulate small groups of related variables.");
                keyword_dict.Add("switch", "The switch statement is a selection statement that chooses a single switch section to execute from a list of candidates based on a pattern match with the " +
                    "match expression.");
                keyword_dict.Add("this", "The this keyword refers to the current instance of the class and is also used as a modifier of the first parameter of an extension method.");
                keyword_dict.Add("throw", "Signals the occurrence of an exception during program execution.");
                keyword_dict.Add("true", "The boolean value that represents when a truth statement is true.");
                keyword_dict.Add("try", "The try block will run a piece of code and will gracefully transfer control to a catch block if an exception is found.");
                keyword_dict.Add("typeof", "The typeof operator obtains the \"System.Type\" instance for a type. The argument to the typeof operator must be the name of a type or a type parameter.");
                keyword_dict.Add("uint", "The uint keyword represents an unsigned 32-bit integer.");
                keyword_dict.Add("ulong", "The ulong keyword represents an unsigned 64-bit integer.");
                keyword_dict.Add("unchecked", "The unchecked keyword is used to suppress overflow-checking for integral-type arithmetic operations and conversions.");
                keyword_dict.Add("unsafe", "The unsafe keyword denotes an unsafe context, which is required for any operation involving pointers.");
                keyword_dict.Add("ushort", "the ushort keyword represents an unsigned 16-bit integer.");
                keyword_dict.Add("using", "The using keyword has three major uses, the using statement defines a scope at then end of which an object will be disposed. The using directive creates an alias " +
                    "for a namespace or imports types defined in other namespaces. The using static directive import the members of a single class.");
                keyword_dict.Add("using static", "The using static directive designates a type whose static members and nested types you can access without specifying a type name. It has special syntax, " +
                    "look it up  if you're interested.");
                keyword_dict.Add("virtual", "The virtual keyword is used to modify a method, indexer, or event declaration and allow for it to be overridden in a derived class.");
                keyword_dict.Add("void", "When used as a return type for a method, void specifies that the method doesn't return a value. Void can also be used in an unsafe context to declare a pointer" +
                    " of an unknown type.");
                keyword_dict.Add("volatile", "The volatile keyword indicates that a field might be modified by multiple threads that are executing at the same time.");
                keyword_dict.Add("while", "The while block will run code inside of it until the truth statement it is associated with is false, or until a goto or break is used.");

            }
            static void Main(string[] args)
        {
            Keywords test = new Keywords();
            Console.WriteLine("For a list of keywords enter \"keywords\"");
            Console.WriteLine("When ready to quit the program, enter \"exit\"");

            while(true)
            {
                Console.WriteLine("Type in a keyword to learn more about it.\n");
                string uinput = Console.ReadLine();
                if (uinput == "exit")
                {
                    break;
                }
                switch (uinput)
                {
                    case "keywords":
                        test.KeywordList();
                        break;
                    default: // Might change this later upon adding more stuff to this
                        Console.WriteLine(test.FindKeyword(uinput) + "\n");
                        break;
                }
            }

            Console.WriteLine("Goodbye!");

        }
    }
}
