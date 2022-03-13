using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AuthServer.Service
{
    public static class ObjectMapper
    {
        
        private static readonly Lazy<IMapper> lazy = new Lazy<IMapper>(() =>
        {
            var config = new MapperConfiguration(cfg =>
            {
                cfg.AddProfile<DtoMapper>();
            });

            return config.CreateMapper();
        });
        /// <summary>
        /// ObjectMapper.Mapper çağırılana kadar memorye static olan bu alan yüklenmeyecektir.
        /// </summary>
        public static IMapper Mapper => lazy.Value;
    }
}
