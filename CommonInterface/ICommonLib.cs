using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommonInterface {
    public interface ICommonObject {
        int Id { get; set; }
        DateTime CreateTime { get; set; }
        DateTime UpdateTime { get; set; }


    }

    public interface IInstrument : ICommonObject {


    }

    public interface ICombiInstrument : IInstrument {



    }

    public interface IDerivInstrument : IInstrument {


    }

    public interface ICFInsrument : IInstrument {



    }
}
