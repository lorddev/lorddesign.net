lorddesign.net
==============

This is a freaking 7-year-old ASP.NET website dating from my previous tenure as a freelancer, before I served a 7-year stint in corporate tech. Before this version created in 2005 there were others, even including one which featured a side-shot silhouette of my dreadlocks. That was fun...

##Notable Features
1. VB code which parses server-side VB (normally not browsable) into readable code output in an html `<pre/>` tag. This is useful for when you find job listings that request to see code you’ve written. When you FTP your
2. Old JS for the expand/collapse controls intended to showcase 7-year-old DOM coding skills.
3. HttpModule for forwarding dead links to old MovableType articles to new location on Blogger (which I’ve actually [moved to Wordpress](http://mustfollow.wordpress.com))

## Plans
1. Fix current bugs where urls to generated html are pointing to the wrong directory.
2. Replace current catch-all email of exceptions with Elmah.
4. Update HTTP Module to forward to Wordpress.
5. Branch it for the new version which will include
	1. A total redesign using [twitter.bootstrap](https://github.com/twitter/bootstrap) 
	2. and my new logo ([drafted here](https://plus.google.com/photos/112726488856143545477/albums/posts/5778978716605790354))
	3. Convert to VS 2010 Web Application in C#, with pre-compiled binaries. Use [ICSharpCode](https://github.com/icsharpcode/NRefactory/) to replace current server-side code parsing (which just loaded .aspx and .vb files as text files and wrapped them in a `<pre/>`).
	4. Also add CSS for code highlighting.

