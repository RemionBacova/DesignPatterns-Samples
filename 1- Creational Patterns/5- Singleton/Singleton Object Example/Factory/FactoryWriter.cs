using Singleton_Object_Example.Interfaces;
using Singleton_Object_Example.Models.Writers;
using Singleton_Object_Example.Models.Writers.Types;
using System;
using System.Collections.Generic;
using System.Text;

namespace Singleton_Object_Example.Factory
{
    class FactoryWriter
    {
        public static IWriter CreateWriter(WriterTypes writerType)
        {
            switch (writerType)
            {
                case WriterTypes.ErrorWriter:
                    return new ErrorWriter();
                case WriterTypes.ExceptionWriter:
                    return new ExceptionWriter();
                case WriterTypes.MessageWriter:
                default:
                    return new MessageWriter();
                    

            }
        }
    }
}
