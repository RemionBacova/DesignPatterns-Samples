Interfaces are used to generalize the behaviour
Abstract class used to generalize common behaviour
You cannot build an abstract class but you can gather there the common behaviour of the derived classes

structure of folders:


- Interfaces  -- used to contain all the interfaces
	|- IStudent -- used to generalize behaviour
- Models   -- used to contain all the models
	|- Student -- used to contain all the student models 
		|- Abstract -- used to contain the common behaviour generalizer
		|    |- StudentAbstract -- abstract class that gathers common behaviour derived by IStudent
		|- BachelorStudent  -- Concrete class for the Bachelor student  derived by StudentAbstract
		|- MasterStudent    -- Concrete class for the Master Student derived by StudentAbstract


TestClass includes the tests over single initializiation and multiple initialization of objects.

