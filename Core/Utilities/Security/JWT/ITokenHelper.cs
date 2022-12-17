using Core.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Utilities.Security.JWT
{
    public interface ITokenHelper
    {
        AccessToken CreateToken(User user, List<OperationClaim> operationClaims);
    }
}
//kullanıcı bilgileri giridkten sonra doğrulama gerçekleşirse bu bölümde  Token oluşturulur.
//(User user) ilgili kullanıcınn , (List<OperationClaim> operationClaims) veri tabanına gidip claimlerini bakıp Token oluşturcak.