# Introduction #

This page is were I put sites that are known to work with Sites.xml but require a special string be placed in the URL so they are not included with the default Sites.xml file. In the future this site may not be needed once I can figure out how to grab this information on the fly.

# Notes #
  * `&` has to be replaced with `&amp;`
  * `GZIP` compressed RSS feeds are supported
  * `<feeds>`, `<groups>`, `<searches>` and `<size>` can be removed when not needed

## NZBMatrix ##
The information needed to replace `[USER]` and `[API]` can be found at http://nzbmatrix.com/api-info.php once you are logged in.

```
      <site name="NZBMatrix">
            <feeds>
                  <feed name="Anime - All">http://rss.nzbmatrix.com/rss.php?page=download&amp;username=[USER]&amp;apikey=[API]&amp;subcat=28</feed>
                  <feed name="Apps - Linux">http://rss.nzbmatrix.com/rss.php?page=download&amp;username=[USER]&amp;apikey=[API]&amp;subcat=20</feed>
                  <feed name="Apps - Mac">http://rss.nzbmatrix.com/rss.php?page=download&amp;username=[USER]&amp;apikey=[API]&amp;subcat=19</feed>
                  <feed name="Apps - Other">http://rss.nzbmatrix.com/rss.php?page=download&amp;username=[USER]&amp;apikey=[API]&amp;subcat=21</feed>
                  <feed name="Apps - PC">http://rss.nzbmatrix.com/rss.php?page=download&amp;username=[USER]&amp;apikey=[API]&amp;subcat=18</feed>
                  <feed name="Apps - Portable">http://rss.nzbmatrix.com/rss.php?page=download&amp;username=[USER]&amp;apikey=[API]&amp;subcat=52</feed>
                  <feed name="Documentaries - HD">http://rss.nzbmatrix.com/rss.php?page=download&amp;username=[USER]&amp;apikey=[API]&amp;subcat=53</feed>
                  <feed name="Documentaries - STD">http://rss.nzbmatrix.com/rss.php?page=download&amp;username=[USER]&amp;apikey=[API]&amp;subcat=9</feed>
                  <feed name="Games - Dreamcast">http://rss.nzbmatrix.com/rss.php?page=download&amp;username=[USER]&amp;apikey=[API]&amp;subcat=16</feed>
                  <feed name="Games - DS">http://rss.nzbmatrix.com/rss.php?page=download&amp;username=[USER]&amp;apikey=[API]&amp;subcat=45</feed>
                  <feed name="Games - GameCube">http://rss.nzbmatrix.com/rss.php?page=download&amp;username=[USER]&amp;apikey=[API]&amp;subcat=46</feed>
                  <feed name="Games - Other">http://rss.nzbmatrix.com/rss.php?page=download&amp;username=[USER]&amp;apikey=[API]&amp;subcat=17</feed>
                  <feed name="Games - PC">http://rss.nzbmatrix.com/rss.php?page=download&amp;username=[USER]&amp;apikey=[API]&amp;subcat=10</feed>
                  <feed name="Games - PS1">http://rss.nzbmatrix.com/rss.php?page=download&amp;username=[USER]&amp;apikey=[API]&amp;subcat=15</feed>
                  <feed name="Games - PS2">http://rss.nzbmatrix.com/rss.php?page=download&amp;username=[USER]&amp;apikey=[API]&amp;subcat=11</feed>
                  <feed name="Games - PS3">http://rss.nzbmatrix.com/rss.php?page=download&amp;username=[USER]&amp;apikey=[API]&amp;subcat=43</feed>
                  <feed name="Games - PSP">http://rss.nzbmatrix.com/rss.php?page=download&amp;username=[USER]&amp;apikey=[API]&amp;subcat=12</feed>
                  <feed name="Games - Wii">http://rss.nzbmatrix.com/rss.php?page=download&amp;username=[USER]&amp;apikey=[API]&amp;subcat=44</feed>
                  <feed name="Games - Wii VC">http://rss.nzbmatrix.com/rss.php?page=download&amp;username=[USER]&amp;apikey=[API]&amp;subcat=51</feed>
                  <feed name="Games - Xbox">http://rss.nzbmatrix.com/rss.php?page=download&amp;username=[USER]&amp;apikey=[API]&amp;subcat=13</feed>
                  <feed name="Games - Xbox360">http://rss.nzbmatrix.com/rss.php?page=download&amp;username=[USER]&amp;apikey=[API]&amp;subcat=14</feed>
                  <feed name="Movies - Divx/Xvid">http://rss.nzbmatrix.com/rss.php?page=download&amp;username=[USER]&amp;apikey=[API]&amp;subcat=2</feed>
                  <feed name="Movies - DVD">http://rss.nzbmatrix.com/rss.php?page=download&amp;username=[USER]&amp;apikey=[API]&amp;subcat=1</feed>
                  <feed name="Movies - HD (Blu-Ray)">http://rss.nzbmatrix.com/rss.php?page=download&amp;username=[USER]&amp;apikey=[API]&amp;subcat=50</feed>
                  <feed name="Movies - HD (x264)">http://rss.nzbmatrix.com/rss.php?page=download&amp;username=[USER]&amp;apikey=[API]&amp;subcat=42</feed>
                  <feed name="Movies - Other">http://rss.nzbmatrix.com/rss.php?page=download&amp;username=[USER]&amp;apikey=[API]&amp;subcat=4</feed>
                  <feed name="Movies - SVCD/VCD">http://rss.nzbmatrix.com/rss.php?page=download&amp;username=[USER]&amp;apikey=[API]&amp;subcat=3</feed>
                  <feed name="Movies - WMV-HD">http://rss.nzbmatrix.com/rss.php?page=download&amp;username=[USER]&amp;apikey=[API]&amp;subcat=48</feed>
                  <feed name="Music - DVD">http://rss.nzbmatrix.com/rss.php?page=download&amp;username=[USER]&amp;apikey=[API]&amp;subcat=24</feed>
                  <feed name="Music - Lossless">http://rss.nzbmatrix.com/rss.php?page=download&amp;username=[USER]&amp;apikey=[API]&amp;subcat=23</feed>
                  <feed name="Music - MP3 Albums">http://rss.nzbmatrix.com/rss.php?page=download&amp;username=[USER]&amp;apikey=[API]&amp;subcat=22</feed>
                  <feed name="Music - MP3 Singles">http://rss.nzbmatrix.com/rss.php?page=download&amp;username=[USER]&amp;apikey=[API]&amp;subcat=47</feed>
                  <feed name="Music - Other">http://rss.nzbmatrix.com/rss.php?page=download&amp;username=[USER]&amp;apikey=[API]&amp;subcat=27</feed>
                  <feed name="Music - Video">http://rss.nzbmatrix.com/rss.php?page=download&amp;username=[USER]&amp;apikey=[API]&amp;subcat=25</feed>
                  <feed name="Other - Audio Books">http://rss.nzbmatrix.com/rss.php?page=download&amp;username=[USER]&amp;apikey=[API]&amp;subcat=49</feed>
                  <feed name="Other - E-Books">http://rss.nzbmatrix.com/rss.php?page=download&amp;username=[USER]&amp;apikey=[API]&amp;subcat=36</feed>
                  <feed name="Other - Emulation">http://rss.nzbmatrix.com/rss.php?page=download&amp;username=[USER]&amp;apikey=[API]&amp;subcat=33</feed>
                  <feed name="Other - Extra Pars/Fills">http://rss.nzbmatrix.com/rss.php?page=download&amp;username=[USER]&amp;apikey=[API]&amp;subcat=39</feed>
                  <feed name="Other - Images">http://rss.nzbmatrix.com/rss.php?page=download&amp;username=[USER]&amp;apikey=[API]&amp;subcat=37</feed>
                  <feed name="Other - Mobile Phone">http://rss.nzbmatrix.com/rss.php?page=download&amp;username=[USER]&amp;apikey=[API]&amp;subcat=38</feed>
                  <feed name="Other - Other">http://rss.nzbmatrix.com/rss.php?page=download&amp;username=[USER]&amp;apikey=[API]&amp;subcat=40</feed>
                  <feed name="Other - PPC/PDA">http://rss.nzbmatrix.com/rss.php?page=download&amp;username=[USER]&amp;apikey=[API]&amp;subcat=34</feed>
                  <feed name="Other - Radio">http://rss.nzbmatrix.com/rss.php?page=download&amp;username=[USER]&amp;apikey=[API]&amp;subcat=26</feed>
                  <feed name="TV - Divx/Xvid">http://rss.nzbmatrix.com/rss.php?page=download&amp;username=[USER]&amp;apikey=[API]&amp;subcat=6</feed>
                  <feed name="TV - DVD">http://rss.nzbmatrix.com/rss.php?page=download&amp;username=[USER]&amp;apikey=[API]&amp;subcat=5</feed>
                  <feed name="TV - HD">http://rss.nzbmatrix.com/rss.php?page=download&amp;username=[USER]&amp;apikey=[API]&amp;subcat=41</feed>
                  <feed name="TV - Other">http://rss.nzbmatrix.com/rss.php?page=download&amp;username=[USER]&amp;apikey=[API]&amp;subcat=8</feed>
                  <feed name="TV - Sport/Ent">http://rss.nzbmatrix.com/rss.php?page=download&amp;username=[USER]&amp;apikey=[API]&amp;subcat=7</feed>
            </feeds>
            <item type="1">
                  <title element="title" />
                  <size type="1" element="description" />
                  <url element="link" />
            </item>
      </site>
```

## NZBs ##

The information needed to replace `[I]` and `[H]` can be found at http://nzbs.org/index.php?action=rss once you are logged in.

```
      <site name="NZBs">
            <feeds>
                  <feed name="My Searches Feed">http://www.nzbs.org/rss.php?action=mysearches&amp;i=[I]&amp;h=[H]&amp;dl=1&amp;num=[MAX]</feed>
                  <feed name="My NZBs Feed">http://www.nzbs.org/rss.php?action=mynzbs&amp;i=[I]&amp;h=[H]&amp;dl=1&amp;num=[MAX]</feed>
                  <feed name="Console">http://www.nzbs.org/rss.php?type=6&amp;i=[I]&amp;h=[H]&amp;dl=1&amp;num=[MAX]</feed>
                  <feed name="Console - NDS">http://www.nzbs.org/rss.php?catid=19&amp;i=[I]&amp;h=[H]&amp;dl=1&amp;num=[MAX]</feed>
                  <feed name="Console - PSP">http://www.nzbs.org/rss.php?catid=16&amp;i=[I]&amp;h=[H]&amp;dl=1&amp;num=[MAX]</feed>
                  <feed name="Console - Wii">http://www.nzbs.org/rss.php?catid=17&amp;i=[I]&amp;h=[H]&amp;dl=1&amp;num=[MAX]</feed>
                  <feed name="Console - XBox">http://www.nzbs.org/rss.php?catid=8&amp;i=[I]&amp;h=[H]&amp;dl=1&amp;num=[MAX]</feed>
                  <feed name="Console - XBox360">http://www.nzbs.org/rss.php?catid=20&amp;i=[I]&amp;h=[H]&amp;dl=1&amp;num=[MAX]</feed>
                  <feed name="Movies">http://www.nzbs.org/rss.php?type=2&amp;i=[I]&amp;h=[H]&amp;dl=1&amp;num=[MAX]</feed>
                  <feed name="Movies - DVD">http://www.nzbs.org/rss.php?catid=9&amp;i=[I]&amp;h=[H]&amp;dl=1&amp;num=[MAX]</feed>
                  <feed name="Movies - XviD">http://www.nzbs.org/rss.php?catid=2&amp;i=[I]&amp;h=[H]&amp;dl=1&amp;num=[MAX]</feed>
                  <feed name="Movies - x264">http://www.nzbs.org/rss.php?catid=4&amp;i=[I]&amp;h=[H]&amp;dl=1&amp;num=[MAX]</feed>
                  <feed name="Music">http://www.nzbs.org/rss.php?type=3&amp;i=[I]&amp;h=[H]&amp;dl=1&amp;num=[MAX]</feed>
                  <feed name="Music - MP3">http://www.nzbs.org/rss.php?catid=5&amp;i=[I]&amp;h=[H]&amp;dl=1&amp;num=[MAX]</feed>
                  <feed name="Music - Video">http://www.nzbs.org/rss.php?catid=10&amp;i=[I]&amp;h=[H]&amp;dl=1&amp;num=[MAX]</feed>
                  <feed name="PC">http://www.nzbs.org/rss.php?type=5&amp;i=[I]&amp;h=[H]&amp;dl=1&amp;num=[MAX]</feed>
                  <feed name="PC - 0day">http://www.nzbs.org/rss.php?catid=7&amp;i=[I]&amp;h=[H]&amp;dl=1&amp;num=[MAX]</feed>
                  <feed name="PC - ISO">http://www.nzbs.org/rss.php?catid=6&amp;i=[I]&amp;h=[H]&amp;dl=1&amp;num=[MAX]</feed>
                  <feed name="PC - Mac">http://www.nzbs.org/rss.php?catid=15&amp;i=[I]&amp;h=[H]&amp;dl=1&amp;num=[MAX]</feed>
                  <feed name="TV">http://www.nzbs.org/rss.php?type=1&amp;i=[I]&amp;h=[H]&amp;dl=1&amp;num=[MAX]</feed>
                  <feed name="TV - DVD">http://www.nzbs.org/rss.php?catid=11&amp;i=[I]&amp;h=[H]&amp;dl=1&amp;num=[MAX]</feed>
                  <feed name="TV - H264">http://www.nzbs.org/rss.php?catid=22&amp;i=[I]&amp;h=[H]&amp;dl=1&amp;num=[MAX]</feed>
                  <feed name="TV - XviD">http://www.nzbs.org/rss.php?catid=1&amp;i=[I]&amp;h=[H]&amp;dl=1&amp;num=[MAX]</feed>
                  <feed name="TV - x264">http://www.nzbs.org/rss.php?catid=14&amp;i=[I]&amp;h=[H]&amp;dl=1&amp;num=[MAX]</feed>
                  <feed name="XXX">http://www.nzbs.org/rss.php?type=4&amp;i=[I]&amp;h=[H]&amp;dl=1&amp;num=[MAX]</feed>
                  <feed name="XXX - DVD">http://www.nzbs.org/rss.php?catid=13&amp;i=[I]&amp;h=[H]&amp;dl=1&amp;num=[MAX]</feed>
                  <feed name="XXX - WMV">http://www.nzbs.org/rss.php?catid=21&amp;i=[I]&amp;h=[H]&amp;dl=1&amp;num=[MAX]</feed>
                  <feed name="XXX - XviD">http://www.nzbs.org/rss.php?catid=3&amp;i=[I]&amp;h=[H]&amp;dl=1&amp;num=[MAX]</feed>
            </feeds>
            <searches>
                  <search name="Default">http://www.nzbs.org/rss.php?q=[QUERY]&amp;i=[I]&amp;h=[H]&amp;dl=1&amp;num=[MAX]</search>
            </searches>
            <item type="1">
                  <title element="title" />
                  <size type="1" element="description" />
                  <url element="link" />
            </item>
      </site>
```

## NZBsRus ##
The information needed to replace `[I]` and `[H]` can be found at http://www.nzbsrus.com/rss.php once you are logged in.

```
      <site name="NZBsRus">
            <feeds>
                  <feed name="Anime">http://www.nzbsrus.com/rssfeed.php?cat=3&amp;i=[I]&amp;h=[H]</feed>
                  <feed name="Apps - 0-Day">http://www.nzbsrus.com/rssfeed.php?cat=6&amp;i=[I]&amp;h=[H]</feed>
                  <feed name="Apps - MAC">http://www.nzbsrus.com/rssfeed.php?cat=93&amp;i=[I]&amp;h=[H]</feed>
                  <feed name="Apps - Misc">http://www.nzbsrus.com/rssfeed.php?cat=9&amp;i=[I]&amp;h=[H]</feed>
                  <feed name="Apps - PC iSO">http://www.nzbsrus.com/rssfeed.php?cat=12&amp;i=[I]&amp;h=[H]</feed>
                  <feed name="Console - Gamecube">http://www.nzbsrus.com/rssfeed.php?cat=87&amp;i=[I]&amp;h=[H]</feed>
                  <feed name="Console - PS2">http://www.nzbsrus.com/rssfeed.php?cat=30&amp;i=[I]&amp;h=[H]</feed>
                  <feed name="Console - PS3">http://www.nzbsrus.com/rssfeed.php?cat=89&amp;i=[I]&amp;h=[H]</feed>
                  <feed name="Console - Wii">http://www.nzbsrus.com/rssfeed.php?cat=92&amp;i=[I]&amp;h=[H]</feed>
                  <feed name="Console - XBOX">http://www.nzbsrus.com/rssfeed.php?cat=39&amp;i=[I]&amp;h=[H]</feed>
                  <feed name="Console - XBOX 360">http://www.nzbsrus.com/rssfeed.php?cat=88&amp;i=[I]&amp;h=[H]</feed>
                  <feed name="eBooks/ Tutorials">http://www.nzbsrus.com/rssfeed.php?cat=15&amp;i=[I]&amp;h=[H]</feed>
                  <feed name="Games - Misc">http://www.nzbsrus.com/rssfeed.php?cat=24&amp;i=[I]&amp;h=[H]</feed>
                  <feed name="Games - PC DOX">http://www.nzbsrus.com/rssfeed.php?cat=96&amp;i=[I]&amp;h=[H]</feed>
                  <feed name="Games - PC iSO">http://www.nzbsrus.com/rssfeed.php?cat=27&amp;i=[I]&amp;h=[H]</feed>
                  <feed name="Handheld - DS">http://www.nzbsrus.com/rssfeed.php?cat=21&amp;i=[I]&amp;h=[H]</feed>
                  <feed name="Handheld - PSP">http://www.nzbsrus.com/rssfeed.php?cat=33&amp;i=[I]&amp;h=[H]</feed>
                  <feed name="Movies - DVDr">http://www.nzbsrus.com/rssfeed.php?cat=45&amp;i=[I]&amp;h=[H]</feed>
                  <feed name="Movies - HD">http://www.nzbsrus.com/rssfeed.php?cat=90&amp;i=[I]&amp;h=[H]</feed>
                  <feed name="Movies - Misc">http://www.nzbsrus.com/rssfeed.php?cat=48&amp;i=[I]&amp;h=[H]</feed>
                  <feed name="Movies - XviD">http://www.nzbsrus.com/rssfeed.php?cat=51&amp;i=[I]&amp;h=[H]</feed>
                  <feed name="Music - MP3">http://www.nzbsrus.com/rssfeed.php?cat=54&amp;i=[I]&amp;h=[H]</feed>
                  <feed name="Music - Video">http://www.nzbsrus.com/rssfeed.php?cat=60&amp;i=[I]&amp;h=[H]</feed>
                  <feed name="Phone">http://www.nzbsrus.com/rssfeed.php?cat=99&amp;i=[I]&amp;h=[H]</feed>
                  <feed name="TV - DVDr">http://www.nzbsrus.com/rssfeed.php?cat=69&amp;i=[I]&amp;h=[H]</feed>
                  <feed name="TV - HD">http://www.nzbsrus.com/rssfeed.php?cat=91&amp;i=[I]&amp;h=[H]</feed>
                  <feed name="TV - Misc">http://www.nzbsrus.com/rssfeed.php?cat=72&amp;i=[I]&amp;h=[H]</feed>
                  <feed name="TV - XviD">http://www.nzbsrus.com/rssfeed.php?cat=75&amp;i=[I]&amp;h=[H]</feed>
            </feeds>
            <item type="1">
                  <title element="title" />
                  <size type="1" element="description" />
                  <url element="link" />
            </item>
      </site>
```

## MyTvNZB ##
The information needed to replace `[ID]` can be found at http://mytvnzb.foechoer.be/ once you select the check boxes of the sites you want to monitor and press `[Generate Feed]`.

```
      <site name="MyTvNZB">
            <feeds>
                  <feed name="Custom Feed">http://mytvnzb.foechoer.be/feed/id/[ID].rss</feed>
            </feeds>
            <item type="1">
                  <title element="title" />
                  <url element="link" />
            </item>
      </site>
```