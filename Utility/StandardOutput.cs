using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Utility
{
    public class StandardOutput:IResponse
    {
        StreamReader _standardOutput;
        public StandardOutput(StreamReader standardOutput)
        {
            if (standardOutput == null)
                throw new Exception("standardOutput cannot be null");
            _standardOutput = standardOutput;
        }

        public void Dispose()
        {
            _standardOutput = null;
        }

        public Stream GetStream()
        {
            return this._standardOutput.BaseStream;
        }
    }
}
