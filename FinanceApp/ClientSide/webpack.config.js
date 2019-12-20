const path = require('path');
module.exports = {
    mode: 'development',
    entry: './Scripts/main.js',
    output: {
        path: path.resolve(__dirname, '../wwwroot/js'),
        filename: 'main.js',

    }
}