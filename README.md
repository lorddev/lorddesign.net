lorddesign.net
==============

![Image](https://github.com/lorddev/lorddesign.net/raw/master/LordDesign.Web/img/lord-design12y.jpg)

[This is an older web property](http://www.lorddesign.net/) dating from my first freelancing career at the turn of the century, before I served a 7-year tenure in corporate tech. The site was updated in 2012 with a new logo and a Twitter Bootstrap fluid grid layout, and jQuery slide pagination which I wrote myself.

The old version had VB code which parsed the server-side VB (normally not browsable) into readable code output in an html `<pre/>` tag. This is useful for when you find job listings that request to see code you’ve written, as IIS (rightly) prevents your ASP.NET files from actually being downloaded, and updating one file didn’t require you to update the other as it was auto-generated. This was a cool trick, but it’s no longer necessary as my code is now publicly visible on GitHub.

The site has an HttpModule for forwarding dead links to old MovableType articles to my new blog (which I [moved to Wordpress](http://mustfollow.wordpress.com))