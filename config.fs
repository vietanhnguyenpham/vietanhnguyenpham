module.exports = {
  Admins: ["UserID", "UserID"], //Admins of the bot
  ExpressServer: true,//If you wanted to make the website run or not
  DefaultPrefix: process.env.Prefix || "v;", //Default prefix, Server Admins can change the prefix
  Port: 3000, //Which port website gonna be hosted
  SupportServer: "https://discord.gg/YHpQdsmSAH", //Support Server Link
  Token: process.env.Token || "MTE5NzUxMzkzMzUzNjM2NjU5Mw.GHYIwa.RUwjTtHz3CaHm1BWii8ezZ7HdBQae2KiK9ud8o", //Discord Bot Token
  ClientID: process.env.Discord_ClientID || "1197513933536366593", //Discord Client ID
  ClientSecret: process.env.Discord_ClientSecret || "DNEPNwssxakV24moLgF39dcn5qmzNdYA", //Discord Client Secret
  Scopes: ["identify", "guilds", "applications.commands"], //Discord OAuth2 Scopes
  CallbackURL: "/api/callback", //Discord OAuth2 Callback URL
  "24/7": false, //If you want the bot to be stay in the vc 24/7
  CookieSecret: "Pikachu is cute", //A Secret like a password
  IconURL:
    "https://raw.githubusercontent.com/SudhanPlayz/Discord-MusicBot/master/assets/logo.gif", //URL of all embed author icons | Dont edit unless you dont need that Music CD Spining
  Permissions: 2205280576, //Bot Inviting Permissions
  Website: process.env.Website || "http://localhost", //Website where it was hosted at includes http or https || Use "0.0.0.0" if you using Heroku

  //Lavalink
   Lavalink: {
    id: "Main",
    host: "lava.link",
    port: 80,
    pass: "youshallnotpass", 
  },
  
  //Alternate Lavalink
  /*
  Lavalink: {
    id: "Main",
    host: "lava.sudhan.tech",
    port: 1234,
    pass: "CodingWithSudhan", 
  },
  */

  //Please go to https://developer.spotify.com/dashboard/
  Spotify: {
    ClientID: process.env.Spotify_ClientID || "ceea152c10a9452db69a1c74d7788caf", //Spotify Client ID
    ClientSecret: process.env.Spotify_ClientSecret || "30303932986a4d12a6f7588d077f5418", //Spotify Client Secret
  },
};

