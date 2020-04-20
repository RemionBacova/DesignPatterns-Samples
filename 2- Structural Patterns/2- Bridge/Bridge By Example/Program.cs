using Bridge_By_Example.BridgeController;
using Bridge_By_Example.Interfaces;
using System;
using System.Collections.Generic;

namespace Bridge_By_Example
{
    class Program
    {
        static void Main(string[] args)
        {
            TestClass testClass = new TestClass();
            testClass.GenerateStudents();

            List<IStudent> list = testClass.ReturnStudents();
            // list contains list of master students and bachelor students

            MessageController messageController = new MessageController();

            foreach(IStudent student in list)
            {
                student.messageType = Models.Messagges.Types.MessageType.SMS;
                // we are setting to same type since it does itself in the set the randomisation of preference
                // randomisation is in the abstract class StudentAbstract.
            }

            foreach(IStudent pickStudent in list)
            {
                messageController.SetMessageType (pickStudent.messageType);

                messageController.SendMessage(pickStudent.Name + pickStudent.Surname, "You are a "+pickStudent.Type+" Student");

            }

        }
    }
}
