# Singleton Pattern

It prevents multiples instances of a class during the execution of the program.

This helps us when we need a class (a kind of service for example) that has to be the same during all the program.

This class is not instantiated until a call is made to any of the public-static fields in it.

Notice the use of "lock" block for preventing two (or more) threads access ata the same time to the class instantiation.

