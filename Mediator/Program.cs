using Mediator.ChatApp;


var teamChat = new TeamChatRoom();

var jhon = new Developer("Jhon");
var ali = new Developer("Ali");
var abbas = new Developer("Abbas");
var snow = new Tester("Snow");

teamChat.RegisterMembers(jhon, ali, abbas, snow);

jhon.SendTo<Developer>("We are deploying today");
snow.Send("I will test it later");
