const knex = require('knex');
const builder = knex({
    client: "mysql",
    connection: {
        host: "127.0.0.1",
        user: "root",
        password: "",
        database: "QLKS"
    },
    pool: {min: 0, max:  100}
});
module.exports = builder;