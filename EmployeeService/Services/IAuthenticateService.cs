﻿using EmployeeService.Models.Dto;
using EmployeeService.Models.Requests;

namespace EmployeeService.Services
{
    public interface IAuthenticateService
    {
        AuthenticationResponse Login(AuthenticationRequest authenticationRequest);

        public SessionDto GetSession(string sessionToken);
    }
}
 