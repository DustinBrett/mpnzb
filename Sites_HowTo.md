# Introduction #
This document will cover the specifications for adding a site to the Sites.xml file included with mpNZB. This [Sites.xml](http://mpnzb.googlecode.com/svn/trunk/mpNZB/Sites/Sites.xml) file contains everything needed to add a site that supports RSS. This document isn't perfect but it's enough to get started. If you find a site that you want to be supported and this document isn't enough for you then contact me on the [forum](http://forum.team-mediaportal.com/plugins-47/mpnzb-nzb-downloader-57265/) and I will help you. For further examples check the [Sites.xml](http://mpnzb.googlecode.com/svn/trunk/mpNZB/Sites/Sites.xml) file or some of the custom ones at the Sites\_Custom wiki.

# Notes #
  * `&` has to be replaced with `&amp;`
  * `GZIP` compressed RSS feeds are supported
  * `<feeds>`, `<groups>`, `<searches>` and `<size>` can be removed when not needed

# Replacement Fields #
These fields will be replaced with the correct data automatically by mpNZB.

  * **`[MAX]`** = Maximum results per feed.
  * **`[GROUP]`** = Usenet group.
  * **`[QUERY]`** = Search string.

# Example Site #
```
<site name="Newzbin">
	<login username="" password="" />
	<feeds>
		<feed name="Everything">http://www.newzbin.com/browse/all/p/?feed=rss&amp;hauth=1&amp;u_post_results_amt=[MAX]</feed>
		<feed name="Unknown">http://www.newzbin.com/browse/category/p/unknown/?feed=rss&amp;hauth=1&amp;u_post_results_amt=[MAX]</feed>
		<feed name="Anime">http://www.newzbin.com/browse/category/p/anime/?feed=rss&amp;hauth=1&amp;u_post_results_amt=[MAX]</feed>
		<feed name="Apps">http://www.newzbin.com/browse/category/p/apps/?feed=rss&amp;hauth=1&amp;u_post_results_amt=[MAX]</feed>
		<feed name="Books">http://www.newzbin.com/browse/category/p/books/?feed=rss&amp;hauth=1&amp;u_post_results_amt=[MAX]</feed>
		<feed name="Consoles">http://www.newzbin.com/browse/category/p/consoles/?feed=rss&amp;hauth=1&amp;u_post_results_amt=[MAX]</feed>
		<feed name="Discussions">http://www.newzbin.com/browse/category/p/discussions/?feed=rss&amp;hauth=1&amp;u_post_results_amt=[MAX]</feed>
		<feed name="Emulation">http://www.newzbin.com/browse/category/p/emulation/?feed=rss&amp;hauth=1&amp;u_post_results_amt=[MAX]</feed>
		<feed name="Games">http://www.newzbin.com/browse/category/p/games/?feed=rss&amp;hauth=1&amp;u_post_results_amt=[MAX]</feed>
		<feed name="Misc">http://www.newzbin.com/browse/category/p/misc/?feed=rss&amp;hauth=1&amp;u_post_results_amt=[MAX]</feed>
		<feed name="Movies">http://www.newzbin.com/browse/category/p/movies/?feed=rss&amp;hauth=1&amp;u_post_results_amt=[MAX]</feed>
		<feed name="Music">http://www.newzbin.com/browse/category/p/music/?feed=rss&amp;hauth=1&amp;u_post_results_amt=[MAX]</feed>
		<feed name="PDA">http://www.newzbin.com/browse/category/p/pda/?feed=rss&amp;hauth=1&amp;u_post_results_amt=[MAX]</feed>
		<feed name="Resources">http://www.newzbin.com/browse/category/p/resources/?feed=rss&amp;hauth=1&amp;u_post_results_amt=[MAX]</feed>
		<feed name="TV">http://www.newzbin.com/browse/category/p/tv/?feed=rss&amp;hauth=1&amp;u_post_results_amt=[MAX]</feed>
	</feeds>
	<groups>http://www.newzbin.com/browse/group/p/[GROUP]/?feed=rss&amp;hauth=1&amp;u_post_results_amt=[MAX]</groups>
	<searches>
		<search name="Default">http://www.newzbin.com/search/query/?q=[QUERY]&amp;fpn=p&amp;searchaction=Go&amp;areadone=-1&amp;feed=rss&amp;hauth=1&amp;u_post_results_amt=[MAX]</search>
	</searches>
	<item type="2">
		<title element="title" />
		<size type="2" element="report:size" />
		<url element="report:id" />
	</item>
</site>
```

## _Login_ ##
This is only required for RSS feeds that support HTTP authentication.

```
<login username="(Username)" password="(Password)" />
```

  * **`(Username)`** = Username for site
  * **`(Password)`** = Password for site

## _Feeds_ ##
This section contains the sites RSS feeds.

```
<feeds>
        <feed name="(Name)">(URL)</feed>
</feeds>
```

  * **`(Name)`** = Name of RSS feed
  * **`(URL)`** = URL to the RSS feed
    * Optionally contain **`[MAX]`**

**Note:** `<feeds>` allows more than one `<feed>`

## _Group_ ##
This section contains the sites group feeds.

```
<groups>(URL)</groups>
```

  * **`(URL)`** = URL to the search feed.
    * Must contain **`[GROUP]`**
    * Optionally contain **`[MAX]`**

## _Search_ ##
This section contains the sites search feeds.

```
<searches>
        <search name="(Name)">(URL)</search>
</searches>
```

  * **`(Name)`** = Name of RSS search feed
  * **`(URL)`** = URL to the search feed.
    * Must contain **`[QUERY]`**
    * Optionally contain **`[MAX]`**

## _Item_ ##
This section contains the data needed to parse the RSS items.

```
<item type="(Type)">
        <title element="(Element)" />
        <size type="(Type)" element="(Element)" />
        <url element="(Element)">
                <regex input="(RegEx)" replacement="(RegEx)"/>
        </url>
</item>
```

  * **`(Type)`** = This identifies what type of item it is
    * **item**
      * 1 = Link to NZB/ZIP
      * 2 = Newzbin ID
    * **size**
      * 1 = String
      * 2 = Bytes
  * **`(Element)`**
    * **title** = RSS element containing title information
    * **size** = RSS element containing size information
    * **url** = RSS element containing url information
  * **`(RegEx)`**
    * **input** = Input string for a regular expressions search
    * **replacement** = Replacement string for the **input** field