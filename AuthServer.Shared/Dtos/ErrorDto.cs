using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AuthServer.Shared.Dtos
{
    public class ErrorDto
    {
        public List<string> Errors { get; private set; }
        public bool IsShow { get; private set; }
        //Yazılım tarafında oluşan hataları sadece Developer'in görmesi için bu property oluşturuldu.
        public ErrorDto()
        {
            Errors = new List<string>();
        }
        public ErrorDto(string error,bool isShow)
        {
            Errors.Add(error);
            isShow = true;
        }
        public ErrorDto(List<string> errors, bool isShow)
        {
            Errors = errors;
            IsShow = isShow;
        }
    }
}
