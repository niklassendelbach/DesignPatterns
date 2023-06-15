using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Adapter
{
    public class Adapter : ITarget
    {
        private readonly Stranger _stranger;
        public Adapter(Stranger stranger)
        {
            _stranger = stranger;
        }
        public void Request()
        {
            _stranger.SpecificRequest();
        }
    }
}
