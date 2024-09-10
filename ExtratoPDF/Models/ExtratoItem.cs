using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtratoPDF.Models
{
    internal record struct ExtratoItem(
        string Date,
        string Description,
        float Value
    );
}
