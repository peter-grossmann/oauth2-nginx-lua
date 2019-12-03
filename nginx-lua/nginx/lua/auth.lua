local opts = {discovery = os.getenv("DISCOVERY_URL")}

-- call bearer_jwt_verify for OAuth 2.0 JWT validation
local res, err = require("resty.openidc").bearer_jwt_verify(opts)

ngx.log(ngx.INFO, tostring(res))
ngx.log(ngx.INFO, tostring(err))

if err or not res then
    ngx.status = 403
    ngx.say(err and err or "no access_token provided")
    ngx.exit(ngx.HTTP_FORBIDDEN)
end

-- at this point res is a Lua table that represents the (validated) JSON
-- payload in the JWT token; now we typically do not want to allow just any
-- token that was issued by the Authorization Server but we want to apply
-- some access restrictions via client IDs or scopes

-- if res.scope ~= "edit" then
--  ngx.exit(ngx.HTTP_FORBIDDEN)
-- end

-- if res.client_id ~= "ro_client" then
--  ngx.exit(ngx.HTTP_FORBIDDEN)
-- end

ngx.req.set_header("X-User", res.sub)
ngx.req.set_header("X-Scope", table.concat(res.scope,", "))
