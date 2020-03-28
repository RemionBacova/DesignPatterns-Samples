Interfaces are used to generalize the behaviour
Abstract class used to generalize common behaviour
You cannot build an abstract class but you can gather there the common behaviour of the derived classes

structure of folders:


- Interfaces  -- used to contain all the interfaces
	|- IStudent -- used to generalize behaviour
	|- IStudentBuilder -- used to generalize behaviour
- Models   -- used to contain all the models
	|- Student -- used to contain all the student models 
		|- Abstract -- used to contain the common behaviour generalizer
		|    |- StudentAbstract -- abstract class that gathers common behaviour derived by IStudent
		|- BachelorStudent  -- Concrete class for the Bachelor student  derived by StudentAbstract
		|- MasterStudent    -- Concrete class for the Master Student derived by StudentAbstract
- Builders  -- used to contain all the builders 
	|- Student -- used to contain all the student builders
		|- Abstract - used to contain the common behaviour of builders
		|	|- StudentBuilderAbstract -- abstract class that gathers the common behaviour derived by IStudentBuilder
		!- BachelorStudentBuilder -- Concrete class for BachelorStudent Builder
		|- MasterStudentBuilder -- Concrete class for MasterStudentBuilder
- Director
	|- DirectorStudentBuilder -- concrete class for the director logic in the Builder pattern
- TestClass -- class for simulating Builder Pattern 


TestClass includes the tests over single initializiation and multiple initialization of objects.

