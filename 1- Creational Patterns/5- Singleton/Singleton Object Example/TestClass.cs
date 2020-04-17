using Singleton_Object_Example.Interfaces;
using Singleton_Object_Example.Models.Writers;
using Singleton_Object_Example.Factory;
using System;
using System.Collections.Generic;
using System.Text;
using Singleton_Object_Example.Models.Writers.Types;

namespace Singleton_Object_Example
{
    class TestClass
    {
        private List<IWriter> writers = new List<IWriter>();
        private List<IWriter> writers2 = new List<IWriter>();
        public void GenerateWriters()
        {
            for (int i = 0; i < 100; i ++ )
            {
                if(i % 3 == 0)
                {
                    writers.Add(Factory.FactoryWriter.CreateWriter(Models.Writers.Types.WriterTypes.MessageWriter));
                }
                else if(i%2 ==0)
                {
                    writers.Add(Factory.FactoryWriter.CreateWriter(Models.Writers.Types.WriterTypes.ExceptionWriter));
                }
                else
                {
                    writers.Add(Factory.FactoryWriter.CreateWriter(Models.Writers.Types.WriterTypes.ErrorWriter));
                }
            }
        }
        public void GenerateWriters2()
        {
            for (int i = 0; i < 100; i++)
            {
                if (i % 5 == 0)
                {
                    writers2.Add(FactoryWriter.CreateWriter(WriterTypes.MessageWriter));
                }
                else if (i % 3 == 0)
                {
                    writers2.Add(FactoryWriter.CreateWriter(WriterTypes.ExceptionWriter));
                }
                else
                {
                    writers2.Add(FactoryWriter.CreateWriter(WriterTypes.ErrorWriter));
                }
            }
        }

        public void SetMSG()
        {
            foreach (IWriter writer in writers)
            {
                if(writer.GetType() == typeof(MessageWriter))
                {
                    ((MessageWriter)writer).GetMsg("Test Message ", "MSG From Writers 1");
                }
                else  if (writer.GetType() == typeof(ExceptionWriter))
                {
                    ((ExceptionWriter)writer).GetMsg(new Exception("Exeption Message", new Exception("Exception from Writers 1")));
                }
                else if (writer.GetType() == typeof(ErrorWriter))
                {
                    ((ErrorWriter)writer).GetMsg("Error Message ", "Error From Writers 1");
                }
            }
        }
        public void SetMSG2()
        {
            foreach (IWriter writer in writers2)
            {
                if (writer.GetType() == typeof(MessageWriter))
                {
                    ((MessageWriter)writer).GetMsg("Test Message ", "MSG From Writers 2");
                }
                else if (writer.GetType() == typeof(ExceptionWriter))
                {
                    ((ExceptionWriter)writer).GetMsg(new Exception("Exeption Message", new Exception("Exception from Writers 2")));
                }
                else if (writer.GetType() == typeof(ErrorWriter))
                {
                    ((ErrorWriter)writer).GetMsg("Error Message ", "Error From Writers 2");
                }
            }
            
        }

        public void GenerateMSG()
        {
            foreach (IWriter writer in writers)
            {
                writer.Compile();
            }
        }

        public void GenerateMSG2()
        {
            foreach (IWriter writer in writers2)
            {
                writer.Compile();
            }
        }

        public void WriteFromWriters()
        {
            foreach (IWriter writer in writers)
            {
                writer.Write();
            }
        }

        public void WriteFromWriters2()
        {
            foreach (IWriter writer in writers2)
            {
                writer.Write();
            }
        }
    }
}
