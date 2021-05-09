# BPBank
A simple banking App with an Angular Typescript UI and a C#/.Net web server on the back-end

This is a work still in progress and the UI is not yet connected to the back-end server.
Currently the UI displays a layout but has no functionality yet.
The UI uses angular materials.
The web server user entityframework to copnnect to sql server. Seeding data is included.

To build C#/.NET back-end cd to the root directory of the project and run

dontnet build

To build and run the Angular change to the directory BPBank\BPBank\ClientApp and run

npm start 

Then navigate to http://localhost:4200/bpbank

Project Structure

BPBank - The web server with controllers
BPBank.Data - Entityframework and repo library for database access
BPBank.MarketData - Library for market data. Fetches FX Rates
BPBank.Domain - Library with business entities and logic
Test.BPBank - Test library for back-end


