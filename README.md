# Fable Minimal App

This is a small Fable app project which illustrates a few fable features, dables with loose functors (from category theory), mathematical composition, and point free computations.

## Requirements

* [dotnet SDK](https://www.microsoft.com/net/download/core) 5.0 or higher
* [node.js](https://nodejs.org)

## Building and running the app

* Install dependencies: `npm install`
* Start the compiler in watch mode and a development server: `npm start`
* After the first compilation is finished, in your browser open: http://localhost:8080/

Any modification you do to the F# code will be reflected in the web page after saving.

> Note: check the "scripts" section in `package.json` to see the commands triggered by the steps above.

## Project structure

### npm

JS dependencies are declared in `package.json`, while `package-lock.json` is a lock file automatically generated.

### Webpack

[Webpack](https://webpack.js.org) is a JS bundler with extensions, like a static dev server that enables hot reloading on code changes. Configuration for Webpack is defined in the `webpack.config.js` file. Note this sample only includes basic Webpack configuration for development mode, if you want to see a more comprehensive configuration check the [Fable webpack-config-template](https://github.com/fable-compiler/webpack-config-template/blob/master/webpack.config.js).

### F#

The sample only contains 5 F# files: the project (.fsproj) and a source file (.fs) in the `src` & `data` folder.

### Web assets

The `index.html` file and other assets like an icon can be found in the `public` folder.
