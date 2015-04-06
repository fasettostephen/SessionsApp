<MTMarkdownOptions output='html4'>
	<a href=""><img src="http://s20.postimg.org/9g7rqt8t9/header.png"/></a>
</MTMarkdownOptions>


##  :white_medium_square: Table of contents
* [Scope](#white_medium_square-scope)
* [Abstract](#white_medium_square-abstract)
* [Requirements](#white_medium_square--requirements)
* [Resources](#white_medium_square--resources)
* [Sample Status](#white_medium_square-samples-status)
	* [By platform](#by-platform)
	* [By demo](#by-demo)
* [Guides](#white_medium_square-guides)
* [Contributors](#white_medium_square-contributors)
* [Contributions](#white_medium_square-contributions)
* [License](#white_medium_square-license)
 

##  :white_medium_square: Scope

This **Xamarin Workshop** was created for the [**The Portuguese National Meeting of IT Students (ENEI)**](http://enei.pt/) by [Sara Silva](https://twitter.com/saramgsilva) which original content is available [here](https://github.com/saramgsilva/XamarinWorkshop). With the goal to extend it to the global community, [Sara Silva](https://twitter.com/saramgsilva) and [Allan Pead](https://twitter.com/adpead) are creating this repository to create a Xamarin Community Workshop to use in user groups events or by developers to learn Xamarin.
 

##  :white_medium_square: Abstract

In this **Xamarin Workshop**, you will learn how to create a Xamarin Forms app, which main goals are:

- Create a Sessions App from the scratch using XAML;
- Apply the Abstraction pattern;
- Apply the MVVM pattern;
- Integrate with Azure App Services;
- Integrate with Azure Notification Hubs;


## :white_medium_square:  Requirements


**Each developer should:**

* Have a Windows or a Mac device;
* Install [Xamarin Studio](http://xamarin.com/download);
* Install [Xamarin IOS](http://developer.xamarin.com/guides/ios/getting_started/installation/) and/or [Xamarin Android](http://developer.xamarin.com/guides/android/getting_started/installation/)
* Install [Xamarin Android Player](https://xamarin.com/android-player) or [Genymotion](https://www.genymotion.com/#!/)
* Install [Visual Studio Community 2013](https://www.visualstudio.com/en-us/news/vs2013-community-vs.aspx)
* Install [Windows Phone 8.1 SDK and Windows SDK for Windows 8.1](https://dev.windows.com/en-us/develop/downloads)


**Notes:**  

1. If you have a Windows device you can create Windows and Android applications. To create iOS applications is always required a Mac, and in this case you can create iOS and Android application using Xamarin Studio. With a Mac and Windows running in Parallels or VMware is possible to create the three targets at the same time (but is required a Windows Phone device to do the deploy!).
2. Xamarin Plugin for Visual Studio in only available for Business plan and for developers that participate in Open Source projects.
3. Each student should get your own Xamarin Student License for free in [xamarin.com/student](https://xamarin.com/student).



## :white_medium_square:  Resources

**Xamarin IOS** |  **Xamarin Android** | **Xamarin Forms**| **Others** |
:---------- | :------------------------ | :------------------------ |:------------------------ |
|[Getting started](http://developer.xamarin.com/guides/ios/getting_started/) | [Getting started](http://developer.xamarin.com/guides/android/getting_started/)|[Getting started](http://developer.xamarin.com/guides/cross-platform/xamarin-forms/)| [Xamarin Recipes](http://developer.xamarin.com/recipes/)
|[API](http://iosapi.xamarin.com/)|[ API](http://androidapi.xamarin.com/)|[API](http://api.xamarin.com/?link=N%3aXamarin.Forms)|[Xamarin Videos](http://developer.xamarin.com/videos/)
|[Guides](http://developer.xamarin.com/guides/ios/)|[Guides](http://developer.xamarin.com/guides/android/)|[Samples](https://github.com/xamarin/xamarin-forms-samples)| [Xamarin Samples](http://developer.xamarin.com/samples-all/)

:pushpin: Ebook

<MTMarkdownOptions output='html4'>
	<a href="http://developer.xamarin.com/guides/cross-platform/xamarin-forms/creating-mobile-apps-xamarin-forms/"><img src="http://developer.xamarin.com/guides/cross-platform/xamarin-forms/creating-mobile-apps-xamarin-forms/Images/Cover-Preview-sml.png" /></a>
</MTMarkdownOptions>


## :white_medium_square: Samples Status

### By platform

  **iOS**|  **Android** |  **WP8.0**  | **Win8.1 Store App**  |  **WPA8.1**  |
:---------- | :------------------------ | :------------------------ | :------------------------ | :------------------------ | 
:white_check_mark:  | :white_check_mark: | :white_check_mark: | :white_check_mark: ( * ) | :white_check_mark: ( * )

(*) This sample is in a preview version and is only available in [Step 7: Add support to WinRT apps](1010ENEI/7.%20Add%20support%20to%20WinRT%20apps).

### By demo

  **Demo** |  **Demo** |  **Online Guide**   | **PDF Guide**   | **Word Guide**   |
:---------- | :------------------------ | :------------------------ | :------------------------ | :------------------------ | 
[1. Create a Xamarin Forms project](src/1.%20Create%20a%20Xamarin%20Forms%20project) | :white_check_mark: | :white_check_mark: | :white_check_mark: |  :white_check_mark: | 
[2. Create the model and data source](src/2.%20Create%20the%20model%20and%20data%20source) | :white_check_mark: | :white_check_mark: | :white_check_mark: |  :white_check_mark: | 
[3. Create the SessionsView](src/3.%20Create%20the%20SessionsView) | :white_check_mark: | :white_check_mark: | :white_check_mark: |  :white_check_mark: | 
[4. Create the SessionDetailsView](src/4.%20Create%20the%20SessionDetailsView) | :white_check_mark: | :white_check_mark: | :white_check_mark: |  :white_check_mark: | 
[5. Add ShareService](src/5.%20Add%20ShareService) | :white_check_mark: | :white_check_mark: | :white_check_mark: |  :white_check_mark: | 
[6. Add splash screen, name and version](src/6.%20Add%20splash%20screen%2C%20name%20and%20version) | :white_check_mark: | :x: |  :x: | :x: | 
[7. Add support to WinRT apps](src/7.%20Add%20support%20to%20WinRT%20apps) | :white_check_mark: | :white_check_mark: | :white_check_mark: |  :white_check_mark: | 
[8. Change the App.cs to App.xaml](src/8. Change the App.cs to App.xaml) | :white_check_mark: | :white_check_mark: | :white_check_mark: |  :white_check_mark: | 
[9. Use MVVM pattern](src/9.%20Use%20MVVM%20Pattern) | :white_check_mark: | :white_check_mark: | :white_check_mark: |  :white_check_mark: | 
[10. Move ItemTemplate to Resources](src/9.%20Move%20ItemTemplate%20to%20Resources) | :white_check_mark: | :white_check_mark: | :white_check_mark: |  :white_check_mark: |


## :white_medium_square: Guides

* [Guides by steps](Guides)
	1. [Create a Xamarin Forms project](Guides/1.%20Create%20a%20Xamarin%20Forms%20project.md)
	    * [Using Xamarin Studio in Mac](Guides/1.%20Create%20a%20Xamarin%20Forms%20project.md#using-xamarin-studio-in-mac)
		* [Using Xamarin Studio in Windows](Guides/1.%20Create%20a%20Xamarin%20Forms%20project.md#using-xamarin-studio-in-windows)
		* [Using Visual Studio in Windows](Guides/1.%20Create%20a%20Xamarin%20Forms%20project.md#using-visual-studio-in-windows)
		* [Running the application](Guides/1.%20Create%20a%20Xamarin%20Forms%20project.md#running-the-application)
		* [Additional notes - Xamarin Forms initialization ](Guides/1.%20Create%20a%20Xamarin%20Forms%20project.md#additional-notes---xamarin-forms-initialization)
	2. [Create the model and data source](Guides/2.%20Create%20the%20model%20and%20the%20data%20source.md)
	3. [Create the SessionsView](Guides/3.%20Create%20the%20SessionsView.md)
		* [Create the Xaml page](Guides/3.%20Create%20the%20SessionsView.md#create-the-xaml-page)
		* [Create the Header](Guides/3.%20Create%20the%20SessionsView.md#create-the-header)
			*[Defining the Images for each platform](Guides/3.%20Create%20the%20SessionsView.md#defining-the-images-for-each-platform)
		* [Create the Listview](Guides/3.%20Create%20the%20SessionsView.md#create-the-listview)
		* [Create the ItemTemplate](Guides/3.%20Create%20the%20SessionsView.md#create-the-itemtemplate)
		* [Create the menu for each Session](Guides/3.%20Create%20the%20SessionsView.md#create-the-menu-for-each-session)
			* [Running the application](Guides/3.%20Create%20the%20SessionsView.md#running-the-application-1)
	4. [Create the SessionDetailsView](Guides/4.%20Create%20the%20SessionDetailsView.md)
		* [Details Gesture](Guides/4.%20Create%20the%20SessionDetailsView.md#the-details-gesture)
		* [Running the application](Guides/4.%20Create%20the%20SessionDetailsView.md#running-the-application-2)
	5. [Add ShareService](Guides/5.%20Add%20ShareService.md)
	    * [Windows Phone](Guides/5.%20Add%20ShareService.md#windows-phone)
		* [Android](Guides/5.%20Add%20ShareService.md#android)
		* [iOS](Guides/5.%20Add%20ShareService.md#ios)
	6. Add splah screen, name and version
	7. [Add support for WinRT Apps](Guides/7.%20Add%20support%20for%20WinRT%20Apps.md)
	8. [Change the App.cs to App.xaml](Guides/8.%20Change%20the%20App.cs%20to%20App.xaml%20copy.md)
	9. [Use MVVM pattern](Guides/9.%20Use%20MVVM%20pattern.md)
	10. [Move ItemTemplate to Resources](10.%20Move%20ItemTemplate%20to%20Resources.md)
* [Wrapping Up](Guides/Wrapping%20Up.md)
	 
* [Complete Guide: 1010 ENEI || Xamarin Workshop](Guides/1010ENEIGuide.md)  

[![PDF Guide](Guides/ImagesForGuides/CoverGuides-small.png)](Guides/CompleteGuide-1010ENEI-Xamarin Workshop.pdf)


## :white_medium_square: Contributors

<MTMarkdownOptions output='html4'>
	<a href="https://twitter.com/saramgsilva"><img src="http://saramgsilva.github.io/NotificationHubs/images/Eu_400x400.png" height="50"/></a>
</MTMarkdownOptions><MTMarkdownOptions output='html4'>
	<a href="https://twitter.com/tritonpt"><img src="https://avatars3.githubusercontent.com/u/602268?v=3&s=460" height="50"/></a>
</MTMarkdownOptions>
<MTMarkdownOptions output='html4'>
	<a href="https://twitter.com/adpead"><img src="http://s20.postimg.org/407wb8del/image.jpg" height="50"/></a>
</MTMarkdownOptions>
<MTMarkdownOptions output='html4'>
	<a href="https://twitter.com/conceptdev"><img src="http://s20.postimg.org/fdufmfnx9/image.jpg" height="50"/></a>
</MTMarkdownOptions>
<MTMarkdownOptions output='html4'>
	<a href="https://twitter.com/agujaran"><img src="http://s20.postimg.org/fda7xyyn1/Gj_SBH2_HR_400x400.jpg" height="50"/></a>
</MTMarkdownOptions>

Thanks to **João Matos**, **Allan Pead**, **Craig Dunn** and **Aditya Gujaran** for the support and the feedback provided!


## :white_medium_square: Contributions

Any developer can contribute using **Draft Branch** or **Review Branch**, and then do a pull request. 
To clarify any doubt please open an issue [here](https://github.com/XamCommunityWorkshop/SessionsApp/issues).


## :white_medium_square: License


MIT License (MIT), read more about it in the [LICENSE file](https://raw.githubusercontent.com/saramgsilva/AMSToolkit/master/LICENSE.txt).
