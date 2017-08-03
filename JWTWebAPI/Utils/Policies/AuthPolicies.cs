using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JWTWebAPI.Utils.Policies
{
    public class AuthPolicies
    {
        public const string ViewUserByUserIdPolicy = "View User by ID";

        public const string ViewUsersPolicy = "View Users";

        public const string ManageUserByUserIdPolicy = "Manage User by ID";

        public const string ManageUsersPolicy = "Manage Users";

        public const string ViewRoleByRoleNamePolicy = "View Role by RoleName";

        public const string ViewRolesPolicy = "View Roles";

        public const string AssignRolesPolicy = "Assign Roles";

        public const string ManageRolesPolicy = "Manage Roles";
    }
}
