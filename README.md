Welcome to Emotion detect and Spell Check app !
===================
----------

What you need ?
-------------
#### <i class="icon-pencil"></i> Suscribe to
- [<i ></i> Azure Portal](https://portal.azure.com)
- [<i ></i> Microsoft Power BI](https://powerbi.microsoft.com)
- [<i ></i> Microsoft Cognitive Services](https://www.microsoft.com/cognitive-services/en-us/)


Sign in with your cognitive services account and then subscribe to new free trials for :

- <i ></i> Bing Spell Check
- <i ></i> Emotion - Preview

Sign in with your azure account and then install :

- <i ></i> Iot Hub
- <i ></i> Stream Analytics job
- <i ></i> Web App

#### <i class="icon-hdd"></i> Installation
On your portal azure, go on your Web App overview -> Application settings.
Add these news app settings value and save changes :

Key                   | Value
--------              | ---
iotHubConnectionString| <#value>
iotHubUri             | <#value>
emotionKey            | <#value>
bingSpellKey          | <#value>


- <i ></i> iotHubConnectionString : 
	- <i> </i> Iot Hub overview -> Shared access policies -> iothubowner -> Connection string primary key
- <i></i> iotHubUri :
	- <i></i> Iot Hub overview -> Hostname
- <i ></i> emotionKey
	- <i></i> Microsoft services account -> Emotion preview Key1
- <i></i> bingSpellKey
	- <i></i> Microsoft services account -> Bing Spell Check Key1

Then, go to Stream Analytics Job overview and add new Input :

- <i></i> Input : name it
- <i></i> Source Type : Data Stream 
- <i></i> Source : your Iot Hub

Add new Output :

- <i></i> Ouput : name it
- <i></i> Sink : Power BI -> Sign in
- <i></i> Dataset Name : name it
- <i></i> Table Name : name it

Add query :
```sql
SELECT
	System.Timestamp AS entryTime,
    scores.anger,
    scores.contempt,
    scores.disgust,
    scores.fear,
    scores.happiness,
    scores.neutral,
    scores.sadness,
    scores.surprise
INTO
    <outputName>
FROM
    <inputName>
```

Now you can start StreamAnalytics job.

####<i class="icon-upload"></i> Publish Web App
First, fork this repo on your gitHub account.
Then, got to your Web App overview on Azure. On continuous delivery menu, configure a new continuous delivery with your GitHub account. Wait for deployment.


Test Web App
-------------------
At this point you can acces to your Web App (Overview -> Url).

This Web App allow you to check spell syntax and check emotion on pictures.

#### <i class="icon-file"></i>Test Emotion detect
On Web App Home, click on "Emotion Detect" -> Select a device -> paste a piture URL in the text box and lick "Analyze"
The picture is diplayed with square arround faces, if you put your muse over faces, you've got the emotion detect.

#### <i class="icon-file"></i>Power BI Analysis
Connect to your Power Bi account -> Streaming Datatsets
Here you can see your DataSet name, clique on chart icon
You can make your chart easily !

![Power BI Exemple](https://github.com/IngesupSOA/YnovDemo-EmotionDetect-SpellCheck/blob/master/imgExemple/2017-03-09_12h28_38.jpg)