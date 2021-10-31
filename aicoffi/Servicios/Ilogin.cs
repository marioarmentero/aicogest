using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace aicoffi.Servicios
{
    public interface Ilogin<T>
    {
        Task<List<T>> GetLoginAsync();
    }
}
