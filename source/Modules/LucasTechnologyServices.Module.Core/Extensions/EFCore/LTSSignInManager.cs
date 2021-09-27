using LucasTechnologyServices.Module.Core.Events;
using MediatR;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;


namespace LucasTechnologyServices.Module.Core.Extensions.EFCore
{
    public class LTSSignInManager<TUser> : SignInManager<TUser> where TUser : class
    {

        private readonly IMediator _mediator;
        private readonly IEnumerable<Claim> additionalClaims;

        public LTSSignInManager(UserManager<TUser> userManager,
            IHttpContextAccessor contextAccessor,
            IUserClaimsPrincipalFactory<TUser> claimsFactory,
            IOptions<IdentityOptions> optionsAccessor,
            ILogger<SignInManager<TUser>> logger,
            IAuthenticationSchemeProvider schemes,
            IUserConfirmation<TUser> confirmation,
            IMediator mediator)
            : base(userManager, contextAccessor, claimsFactory, optionsAccessor, logger, schemes, confirmation)

            
        {
            _mediator = mediator;
        }

        public override async Task SignInWithClaimsAsync(TUser user, AuthenticationProperties authenticationProperties, IEnumerable<Claim> additionalClaim)
        {
            await base.SignInWithClaimsAsync(user, authenticationProperties, additionalClaims);
            var userId = await UserManager.GetUserIdAsync(user);
            await _mediator.Publish(new UserSignedIn { UserId = long.Parse(userId) });

        }
    }
}
