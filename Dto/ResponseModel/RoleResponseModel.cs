﻿namespace HMS.Dto.ResponseModel
{  public class RoleResponseModel : BaseResponse
    {
        public RoleDto Data { get; set; }
    }

    public class RolesResponseModel : BaseResponse
    {
        public List<RoleDto> Data { get; set; }
    }
}
