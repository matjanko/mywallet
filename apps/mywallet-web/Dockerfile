FROM node:18-alpine as build

WORKDIR /app

COPY package.json ./

RUN npm install --legacy-peer-deps

COPY . .
RUN npm run build -- --output-path=dist --output-hashing=all

FROM nginx:1.23.4-alpine
COPY nginx.conf /etc/nginx/nginx.conf
COPY --from=build /app/dist /usr/share/nginx/html

CMD ["nginx", "-g", "daemon off;"]
