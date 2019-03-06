// source: https://github.com/fable-compiler/fable-suave-scaffold/blob/master/src/Client/webpack.config.js

var path = require("path");
var webpack = require("webpack");

var cfg = {
  devtool: "source-map",
  entry: "./temp/code.js", // fable outputs javascript files here, and this is the webpack entry
  output: {
    path: path.join(__dirname, "public"),
    filename: "bundle.js"
  },
  module: {
      rules: [
        {
            test: /\.js$/,
            exclude: /node_modules/,
            loader: "source-map-loader",
            enforce: "pre"
        }
      ]
  }
};

module.exports = cfg;