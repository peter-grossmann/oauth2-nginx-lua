FROM openresty/openresty:alpine-fat

RUN luarocks install lua-resty-session
RUN luarocks install lua-resty-http
RUN luarocks install lua-resty-jwt
RUN luarocks install lua-resty-openidc

COPY nginx /usr/local/openresty/nginx/

RUN chmod -R 777 /var/run/openresty
RUN chmod -R 777 /usr/local/openresty/nginx