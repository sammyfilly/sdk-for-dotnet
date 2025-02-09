
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Appwrite.Models;

namespace Appwrite.Services
{
    public class Users : Service
    {
        public Users(Client client) : base(client)
        {
        }

        /// <summary>
        /// List Users
        /// <para>
        /// Get a list of all the project's users. You can use the query params to
        /// filter your results.
        /// </para>
        /// </summary>
        public Task<Models.UserList> List(List<string>? queries = null, string? search = null)
        {
            var apiPath = "/users";

            var apiParameters = new Dictionary<string, object?>()
            {
                { "queries", queries },
                { "search", search }
            };

            var apiHeaders = new Dictionary<string, string>()
            {
                { "content-type", "application/json" }
            };



            static Models.UserList Convert(Dictionary<string, object> it) =>
                Models.UserList.From(map: it);


            return _client.Call<Models.UserList>(
                method: "GET",
                path: apiPath,
                headers: apiHeaders,
                parameters: apiParameters.Where(it => it.Value != null).ToDictionary(it => it.Key, it => it.Value)!,
                convert: Convert);

        }

        /// <summary>
        /// Create User
        /// <para>
        /// Create a new user.
        /// </para>
        /// </summary>
        public Task<Models.User> Create(string userId, string? email = null, string? phone = null, string? password = null, string? name = null)
        {
            var apiPath = "/users";

            var apiParameters = new Dictionary<string, object?>()
            {
                { "userId", userId },
                { "email", email },
                { "phone", phone },
                { "password", password },
                { "name", name }
            };

            var apiHeaders = new Dictionary<string, string>()
            {
                { "content-type", "application/json" }
            };



            static Models.User Convert(Dictionary<string, object> it) =>
                Models.User.From(map: it);


            return _client.Call<Models.User>(
                method: "POST",
                path: apiPath,
                headers: apiHeaders,
                parameters: apiParameters.Where(it => it.Value != null).ToDictionary(it => it.Key, it => it.Value)!,
                convert: Convert);

        }

        /// <summary>
        /// Create User with Argon2 Password
        /// <para>
        /// Create a new user. Password provided must be hashed with the
        /// [Argon2](https://en.wikipedia.org/wiki/Argon2) algorithm. Use the [POST
        /// /users](/docs/server/users#usersCreate) endpoint to create users with a
        /// plain text password.
        /// </para>
        /// </summary>
        public Task<Models.User> CreateArgon2User(string userId, string email, string password, string? name = null)
        {
            var apiPath = "/users/argon2";

            var apiParameters = new Dictionary<string, object?>()
            {
                { "userId", userId },
                { "email", email },
                { "password", password },
                { "name", name }
            };

            var apiHeaders = new Dictionary<string, string>()
            {
                { "content-type", "application/json" }
            };



            static Models.User Convert(Dictionary<string, object> it) =>
                Models.User.From(map: it);


            return _client.Call<Models.User>(
                method: "POST",
                path: apiPath,
                headers: apiHeaders,
                parameters: apiParameters.Where(it => it.Value != null).ToDictionary(it => it.Key, it => it.Value)!,
                convert: Convert);

        }

        /// <summary>
        /// Create User with Bcrypt Password
        /// <para>
        /// Create a new user. Password provided must be hashed with the
        /// [Bcrypt](https://en.wikipedia.org/wiki/Bcrypt) algorithm. Use the [POST
        /// /users](/docs/server/users#usersCreate) endpoint to create users with a
        /// plain text password.
        /// </para>
        /// </summary>
        public Task<Models.User> CreateBcryptUser(string userId, string email, string password, string? name = null)
        {
            var apiPath = "/users/bcrypt";

            var apiParameters = new Dictionary<string, object?>()
            {
                { "userId", userId },
                { "email", email },
                { "password", password },
                { "name", name }
            };

            var apiHeaders = new Dictionary<string, string>()
            {
                { "content-type", "application/json" }
            };



            static Models.User Convert(Dictionary<string, object> it) =>
                Models.User.From(map: it);


            return _client.Call<Models.User>(
                method: "POST",
                path: apiPath,
                headers: apiHeaders,
                parameters: apiParameters.Where(it => it.Value != null).ToDictionary(it => it.Key, it => it.Value)!,
                convert: Convert);

        }

        /// <summary>
        /// List Identities
        /// <para>
        /// Get identities for all users.
        /// </para>
        /// </summary>
        public Task<Models.IdentityList> ListIdentities(string? queries = null, string? search = null)
        {
            var apiPath = "/users/identities";

            var apiParameters = new Dictionary<string, object?>()
            {
                { "queries", queries },
                { "search", search }
            };

            var apiHeaders = new Dictionary<string, string>()
            {
                { "content-type", "application/json" }
            };



            static Models.IdentityList Convert(Dictionary<string, object> it) =>
                Models.IdentityList.From(map: it);


            return _client.Call<Models.IdentityList>(
                method: "GET",
                path: apiPath,
                headers: apiHeaders,
                parameters: apiParameters.Where(it => it.Value != null).ToDictionary(it => it.Key, it => it.Value)!,
                convert: Convert);

        }

        /// <summary>
        /// Delete Identity
        /// <para>
        /// Delete an identity by its unique ID.
        /// </para>
        /// </summary>
        public Task<object> DeleteIdentity(string identityId)
        {
            var apiPath = "/users/identities/{identityId}"
                .Replace("{identityId}", identityId);

            var apiParameters = new Dictionary<string, object?>()
            {
            };

            var apiHeaders = new Dictionary<string, string>()
            {
                { "content-type", "application/json" }
            };





            return _client.Call<object>(
                method: "DELETE",
                path: apiPath,
                headers: apiHeaders,
                parameters: apiParameters.Where(it => it.Value != null).ToDictionary(it => it.Key, it => it.Value)!);

        }

        /// <summary>
        /// Create User with MD5 Password
        /// <para>
        /// Create a new user. Password provided must be hashed with the
        /// [MD5](https://en.wikipedia.org/wiki/MD5) algorithm. Use the [POST
        /// /users](/docs/server/users#usersCreate) endpoint to create users with a
        /// plain text password.
        /// </para>
        /// </summary>
        public Task<Models.User> CreateMD5User(string userId, string email, string password, string? name = null)
        {
            var apiPath = "/users/md5";

            var apiParameters = new Dictionary<string, object?>()
            {
                { "userId", userId },
                { "email", email },
                { "password", password },
                { "name", name }
            };

            var apiHeaders = new Dictionary<string, string>()
            {
                { "content-type", "application/json" }
            };



            static Models.User Convert(Dictionary<string, object> it) =>
                Models.User.From(map: it);


            return _client.Call<Models.User>(
                method: "POST",
                path: apiPath,
                headers: apiHeaders,
                parameters: apiParameters.Where(it => it.Value != null).ToDictionary(it => it.Key, it => it.Value)!,
                convert: Convert);

        }

        /// <summary>
        /// Create User with PHPass Password
        /// <para>
        /// Create a new user. Password provided must be hashed with the
        /// [PHPass](https://www.openwall.com/phpass/) algorithm. Use the [POST
        /// /users](/docs/server/users#usersCreate) endpoint to create users with a
        /// plain text password.
        /// </para>
        /// </summary>
        public Task<Models.User> CreatePHPassUser(string userId, string email, string password, string? name = null)
        {
            var apiPath = "/users/phpass";

            var apiParameters = new Dictionary<string, object?>()
            {
                { "userId", userId },
                { "email", email },
                { "password", password },
                { "name", name }
            };

            var apiHeaders = new Dictionary<string, string>()
            {
                { "content-type", "application/json" }
            };



            static Models.User Convert(Dictionary<string, object> it) =>
                Models.User.From(map: it);


            return _client.Call<Models.User>(
                method: "POST",
                path: apiPath,
                headers: apiHeaders,
                parameters: apiParameters.Where(it => it.Value != null).ToDictionary(it => it.Key, it => it.Value)!,
                convert: Convert);

        }

        /// <summary>
        /// Create User with Scrypt Password
        /// <para>
        /// Create a new user. Password provided must be hashed with the
        /// [Scrypt](https://github.com/Tarsnap/scrypt) algorithm. Use the [POST
        /// /users](/docs/server/users#usersCreate) endpoint to create users with a
        /// plain text password.
        /// </para>
        /// </summary>
        public Task<Models.User> CreateScryptUser(string userId, string email, string password, string passwordSalt, long passwordCpu, long passwordMemory, long passwordParallel, long passwordLength, string? name = null)
        {
            var apiPath = "/users/scrypt";

            var apiParameters = new Dictionary<string, object?>()
            {
                { "userId", userId },
                { "email", email },
                { "password", password },
                { "passwordSalt", passwordSalt },
                { "passwordCpu", passwordCpu },
                { "passwordMemory", passwordMemory },
                { "passwordParallel", passwordParallel },
                { "passwordLength", passwordLength },
                { "name", name }
            };

            var apiHeaders = new Dictionary<string, string>()
            {
                { "content-type", "application/json" }
            };



            static Models.User Convert(Dictionary<string, object> it) =>
                Models.User.From(map: it);


            return _client.Call<Models.User>(
                method: "POST",
                path: apiPath,
                headers: apiHeaders,
                parameters: apiParameters.Where(it => it.Value != null).ToDictionary(it => it.Key, it => it.Value)!,
                convert: Convert);

        }

        /// <summary>
        /// Create User with Scrypt Modified Password
        /// <para>
        /// Create a new user. Password provided must be hashed with the [Scrypt
        /// Modified](https://gist.github.com/Meldiron/eecf84a0225eccb5a378d45bb27462cc)
        /// algorithm. Use the [POST /users](/docs/server/users#usersCreate) endpoint
        /// to create users with a plain text password.
        /// </para>
        /// </summary>
        public Task<Models.User> CreateScryptModifiedUser(string userId, string email, string password, string passwordSalt, string passwordSaltSeparator, string passwordSignerKey, string? name = null)
        {
            var apiPath = "/users/scrypt-modified";

            var apiParameters = new Dictionary<string, object?>()
            {
                { "userId", userId },
                { "email", email },
                { "password", password },
                { "passwordSalt", passwordSalt },
                { "passwordSaltSeparator", passwordSaltSeparator },
                { "passwordSignerKey", passwordSignerKey },
                { "name", name }
            };

            var apiHeaders = new Dictionary<string, string>()
            {
                { "content-type", "application/json" }
            };



            static Models.User Convert(Dictionary<string, object> it) =>
                Models.User.From(map: it);


            return _client.Call<Models.User>(
                method: "POST",
                path: apiPath,
                headers: apiHeaders,
                parameters: apiParameters.Where(it => it.Value != null).ToDictionary(it => it.Key, it => it.Value)!,
                convert: Convert);

        }

        /// <summary>
        /// Create User with SHA Password
        /// <para>
        /// Create a new user. Password provided must be hashed with the
        /// [SHA](https://en.wikipedia.org/wiki/Secure_Hash_Algorithm) algorithm. Use
        /// the [POST /users](/docs/server/users#usersCreate) endpoint to create users
        /// with a plain text password.
        /// </para>
        /// </summary>
        public Task<Models.User> CreateSHAUser(string userId, string email, string password, string? passwordVersion = null, string? name = null)
        {
            var apiPath = "/users/sha";

            var apiParameters = new Dictionary<string, object?>()
            {
                { "userId", userId },
                { "email", email },
                { "password", password },
                { "passwordVersion", passwordVersion },
                { "name", name }
            };

            var apiHeaders = new Dictionary<string, string>()
            {
                { "content-type", "application/json" }
            };



            static Models.User Convert(Dictionary<string, object> it) =>
                Models.User.From(map: it);


            return _client.Call<Models.User>(
                method: "POST",
                path: apiPath,
                headers: apiHeaders,
                parameters: apiParameters.Where(it => it.Value != null).ToDictionary(it => it.Key, it => it.Value)!,
                convert: Convert);

        }

        /// <summary>
        /// Get User
        /// <para>
        /// Get a user by its unique ID.
        /// </para>
        /// </summary>
        public Task<Models.User> Get(string userId)
        {
            var apiPath = "/users/{userId}"
                .Replace("{userId}", userId);

            var apiParameters = new Dictionary<string, object?>()
            {
            };

            var apiHeaders = new Dictionary<string, string>()
            {
                { "content-type", "application/json" }
            };



            static Models.User Convert(Dictionary<string, object> it) =>
                Models.User.From(map: it);


            return _client.Call<Models.User>(
                method: "GET",
                path: apiPath,
                headers: apiHeaders,
                parameters: apiParameters.Where(it => it.Value != null).ToDictionary(it => it.Key, it => it.Value)!,
                convert: Convert);

        }

        /// <summary>
        /// Delete User
        /// <para>
        /// Delete a user by its unique ID, thereby releasing it's ID. Since ID is
        /// released and can be reused, all user-related resources like documents or
        /// storage files should be deleted before user deletion. If you want to keep
        /// ID reserved, use the [updateStatus](/docs/server/users#usersUpdateStatus)
        /// endpoint instead.
        /// </para>
        /// </summary>
        public Task<object> Delete(string userId)
        {
            var apiPath = "/users/{userId}"
                .Replace("{userId}", userId);

            var apiParameters = new Dictionary<string, object?>()
            {
            };

            var apiHeaders = new Dictionary<string, string>()
            {
                { "content-type", "application/json" }
            };





            return _client.Call<object>(
                method: "DELETE",
                path: apiPath,
                headers: apiHeaders,
                parameters: apiParameters.Where(it => it.Value != null).ToDictionary(it => it.Key, it => it.Value)!);

        }

        /// <summary>
        /// Update Email
        /// <para>
        /// Update the user email by its unique ID.
        /// </para>
        /// </summary>
        public Task<Models.User> UpdateEmail(string userId, string email)
        {
            var apiPath = "/users/{userId}/email"
                .Replace("{userId}", userId);

            var apiParameters = new Dictionary<string, object?>()
            {
                { "email", email }
            };

            var apiHeaders = new Dictionary<string, string>()
            {
                { "content-type", "application/json" }
            };



            static Models.User Convert(Dictionary<string, object> it) =>
                Models.User.From(map: it);


            return _client.Call<Models.User>(
                method: "PATCH",
                path: apiPath,
                headers: apiHeaders,
                parameters: apiParameters.Where(it => it.Value != null).ToDictionary(it => it.Key, it => it.Value)!,
                convert: Convert);

        }

        /// <summary>
        /// Update User Labels
        /// <para>
        /// Update the user labels by its unique ID. 
        /// 
        /// Labels can be used to grant access to resources. While teams are a way for
        /// user's to share access to a resource, labels can be defined by the
        /// developer to grant access without an invitation. See the [Permissions
        /// docs](/docs/permissions) for more info.
        /// </para>
        /// </summary>
        public Task<Models.User> UpdateLabels(string userId, List<string> labels)
        {
            var apiPath = "/users/{userId}/labels"
                .Replace("{userId}", userId);

            var apiParameters = new Dictionary<string, object?>()
            {
                { "labels", labels }
            };

            var apiHeaders = new Dictionary<string, string>()
            {
                { "content-type", "application/json" }
            };



            static Models.User Convert(Dictionary<string, object> it) =>
                Models.User.From(map: it);


            return _client.Call<Models.User>(
                method: "PUT",
                path: apiPath,
                headers: apiHeaders,
                parameters: apiParameters.Where(it => it.Value != null).ToDictionary(it => it.Key, it => it.Value)!,
                convert: Convert);

        }

        /// <summary>
        /// List User Logs
        /// <para>
        /// Get the user activity logs list by its unique ID.
        /// </para>
        /// </summary>
        public Task<Models.LogList> ListLogs(string userId, List<string>? queries = null)
        {
            var apiPath = "/users/{userId}/logs"
                .Replace("{userId}", userId);

            var apiParameters = new Dictionary<string, object?>()
            {
                { "queries", queries }
            };

            var apiHeaders = new Dictionary<string, string>()
            {
                { "content-type", "application/json" }
            };



            static Models.LogList Convert(Dictionary<string, object> it) =>
                Models.LogList.From(map: it);


            return _client.Call<Models.LogList>(
                method: "GET",
                path: apiPath,
                headers: apiHeaders,
                parameters: apiParameters.Where(it => it.Value != null).ToDictionary(it => it.Key, it => it.Value)!,
                convert: Convert);

        }

        /// <summary>
        /// List User Memberships
        /// <para>
        /// Get the user membership list by its unique ID.
        /// </para>
        /// </summary>
        public Task<Models.MembershipList> ListMemberships(string userId)
        {
            var apiPath = "/users/{userId}/memberships"
                .Replace("{userId}", userId);

            var apiParameters = new Dictionary<string, object?>()
            {
            };

            var apiHeaders = new Dictionary<string, string>()
            {
                { "content-type", "application/json" }
            };



            static Models.MembershipList Convert(Dictionary<string, object> it) =>
                Models.MembershipList.From(map: it);


            return _client.Call<Models.MembershipList>(
                method: "GET",
                path: apiPath,
                headers: apiHeaders,
                parameters: apiParameters.Where(it => it.Value != null).ToDictionary(it => it.Key, it => it.Value)!,
                convert: Convert);

        }

        /// <summary>
        /// Update Name
        /// <para>
        /// Update the user name by its unique ID.
        /// </para>
        /// </summary>
        public Task<Models.User> UpdateName(string userId, string name)
        {
            var apiPath = "/users/{userId}/name"
                .Replace("{userId}", userId);

            var apiParameters = new Dictionary<string, object?>()
            {
                { "name", name }
            };

            var apiHeaders = new Dictionary<string, string>()
            {
                { "content-type", "application/json" }
            };



            static Models.User Convert(Dictionary<string, object> it) =>
                Models.User.From(map: it);


            return _client.Call<Models.User>(
                method: "PATCH",
                path: apiPath,
                headers: apiHeaders,
                parameters: apiParameters.Where(it => it.Value != null).ToDictionary(it => it.Key, it => it.Value)!,
                convert: Convert);

        }

        /// <summary>
        /// Update Password
        /// <para>
        /// Update the user password by its unique ID.
        /// </para>
        /// </summary>
        public Task<Models.User> UpdatePassword(string userId, string password)
        {
            var apiPath = "/users/{userId}/password"
                .Replace("{userId}", userId);

            var apiParameters = new Dictionary<string, object?>()
            {
                { "password", password }
            };

            var apiHeaders = new Dictionary<string, string>()
            {
                { "content-type", "application/json" }
            };



            static Models.User Convert(Dictionary<string, object> it) =>
                Models.User.From(map: it);


            return _client.Call<Models.User>(
                method: "PATCH",
                path: apiPath,
                headers: apiHeaders,
                parameters: apiParameters.Where(it => it.Value != null).ToDictionary(it => it.Key, it => it.Value)!,
                convert: Convert);

        }

        /// <summary>
        /// Update Phone
        /// <para>
        /// Update the user phone by its unique ID.
        /// </para>
        /// </summary>
        public Task<Models.User> UpdatePhone(string userId, string number)
        {
            var apiPath = "/users/{userId}/phone"
                .Replace("{userId}", userId);

            var apiParameters = new Dictionary<string, object?>()
            {
                { "number", number }
            };

            var apiHeaders = new Dictionary<string, string>()
            {
                { "content-type", "application/json" }
            };



            static Models.User Convert(Dictionary<string, object> it) =>
                Models.User.From(map: it);


            return _client.Call<Models.User>(
                method: "PATCH",
                path: apiPath,
                headers: apiHeaders,
                parameters: apiParameters.Where(it => it.Value != null).ToDictionary(it => it.Key, it => it.Value)!,
                convert: Convert);

        }

        /// <summary>
        /// Get User Preferences
        /// <para>
        /// Get the user preferences by its unique ID.
        /// </para>
        /// </summary>
        public Task<Models.Preferences> GetPrefs(string userId)
        {
            var apiPath = "/users/{userId}/prefs"
                .Replace("{userId}", userId);

            var apiParameters = new Dictionary<string, object?>()
            {
            };

            var apiHeaders = new Dictionary<string, string>()
            {
                { "content-type", "application/json" }
            };



            static Models.Preferences Convert(Dictionary<string, object> it) =>
                Models.Preferences.From(map: it);


            return _client.Call<Models.Preferences>(
                method: "GET",
                path: apiPath,
                headers: apiHeaders,
                parameters: apiParameters.Where(it => it.Value != null).ToDictionary(it => it.Key, it => it.Value)!,
                convert: Convert);

        }

        /// <summary>
        /// Update User Preferences
        /// <para>
        /// Update the user preferences by its unique ID. The object you pass is stored
        /// as is, and replaces any previous value. The maximum allowed prefs size is
        /// 64kB and throws error if exceeded.
        /// </para>
        /// </summary>
        public Task<Models.Preferences> UpdatePrefs(string userId, object prefs)
        {
            var apiPath = "/users/{userId}/prefs"
                .Replace("{userId}", userId);

            var apiParameters = new Dictionary<string, object?>()
            {
                { "prefs", prefs }
            };

            var apiHeaders = new Dictionary<string, string>()
            {
                { "content-type", "application/json" }
            };



            static Models.Preferences Convert(Dictionary<string, object> it) =>
                Models.Preferences.From(map: it);


            return _client.Call<Models.Preferences>(
                method: "PATCH",
                path: apiPath,
                headers: apiHeaders,
                parameters: apiParameters.Where(it => it.Value != null).ToDictionary(it => it.Key, it => it.Value)!,
                convert: Convert);

        }

        /// <summary>
        /// List User Sessions
        /// <para>
        /// Get the user sessions list by its unique ID.
        /// </para>
        /// </summary>
        public Task<Models.SessionList> ListSessions(string userId)
        {
            var apiPath = "/users/{userId}/sessions"
                .Replace("{userId}", userId);

            var apiParameters = new Dictionary<string, object?>()
            {
            };

            var apiHeaders = new Dictionary<string, string>()
            {
                { "content-type", "application/json" }
            };



            static Models.SessionList Convert(Dictionary<string, object> it) =>
                Models.SessionList.From(map: it);


            return _client.Call<Models.SessionList>(
                method: "GET",
                path: apiPath,
                headers: apiHeaders,
                parameters: apiParameters.Where(it => it.Value != null).ToDictionary(it => it.Key, it => it.Value)!,
                convert: Convert);

        }

        /// <summary>
        /// Delete User Sessions
        /// <para>
        /// Delete all user's sessions by using the user's unique ID.
        /// </para>
        /// </summary>
        public Task<object> DeleteSessions(string userId)
        {
            var apiPath = "/users/{userId}/sessions"
                .Replace("{userId}", userId);

            var apiParameters = new Dictionary<string, object?>()
            {
            };

            var apiHeaders = new Dictionary<string, string>()
            {
                { "content-type", "application/json" }
            };





            return _client.Call<object>(
                method: "DELETE",
                path: apiPath,
                headers: apiHeaders,
                parameters: apiParameters.Where(it => it.Value != null).ToDictionary(it => it.Key, it => it.Value)!);

        }

        /// <summary>
        /// Delete User Session
        /// <para>
        /// Delete a user sessions by its unique ID.
        /// </para>
        /// </summary>
        public Task<object> DeleteSession(string userId, string sessionId)
        {
            var apiPath = "/users/{userId}/sessions/{sessionId}"
                .Replace("{userId}", userId)
                .Replace("{sessionId}", sessionId);

            var apiParameters = new Dictionary<string, object?>()
            {
            };

            var apiHeaders = new Dictionary<string, string>()
            {
                { "content-type", "application/json" }
            };





            return _client.Call<object>(
                method: "DELETE",
                path: apiPath,
                headers: apiHeaders,
                parameters: apiParameters.Where(it => it.Value != null).ToDictionary(it => it.Key, it => it.Value)!);

        }

        /// <summary>
        /// Update User Status
        /// <para>
        /// Update the user status by its unique ID. Use this endpoint as an
        /// alternative to deleting a user if you want to keep user's ID reserved.
        /// </para>
        /// </summary>
        public Task<Models.User> UpdateStatus(string userId, bool status)
        {
            var apiPath = "/users/{userId}/status"
                .Replace("{userId}", userId);

            var apiParameters = new Dictionary<string, object?>()
            {
                { "status", status }
            };

            var apiHeaders = new Dictionary<string, string>()
            {
                { "content-type", "application/json" }
            };



            static Models.User Convert(Dictionary<string, object> it) =>
                Models.User.From(map: it);


            return _client.Call<Models.User>(
                method: "PATCH",
                path: apiPath,
                headers: apiHeaders,
                parameters: apiParameters.Where(it => it.Value != null).ToDictionary(it => it.Key, it => it.Value)!,
                convert: Convert);

        }

        /// <summary>
        /// Update Email Verification
        /// <para>
        /// Update the user email verification status by its unique ID.
        /// </para>
        /// </summary>
        public Task<Models.User> UpdateEmailVerification(string userId, bool emailVerification)
        {
            var apiPath = "/users/{userId}/verification"
                .Replace("{userId}", userId);

            var apiParameters = new Dictionary<string, object?>()
            {
                { "emailVerification", emailVerification }
            };

            var apiHeaders = new Dictionary<string, string>()
            {
                { "content-type", "application/json" }
            };



            static Models.User Convert(Dictionary<string, object> it) =>
                Models.User.From(map: it);


            return _client.Call<Models.User>(
                method: "PATCH",
                path: apiPath,
                headers: apiHeaders,
                parameters: apiParameters.Where(it => it.Value != null).ToDictionary(it => it.Key, it => it.Value)!,
                convert: Convert);

        }

        /// <summary>
        /// Update Phone Verification
        /// <para>
        /// Update the user phone verification status by its unique ID.
        /// </para>
        /// </summary>
        public Task<Models.User> UpdatePhoneVerification(string userId, bool phoneVerification)
        {
            var apiPath = "/users/{userId}/verification/phone"
                .Replace("{userId}", userId);

            var apiParameters = new Dictionary<string, object?>()
            {
                { "phoneVerification", phoneVerification }
            };

            var apiHeaders = new Dictionary<string, string>()
            {
                { "content-type", "application/json" }
            };



            static Models.User Convert(Dictionary<string, object> it) =>
                Models.User.From(map: it);


            return _client.Call<Models.User>(
                method: "PATCH",
                path: apiPath,
                headers: apiHeaders,
                parameters: apiParameters.Where(it => it.Value != null).ToDictionary(it => it.Key, it => it.Value)!,
                convert: Convert);

        }

    }
}
