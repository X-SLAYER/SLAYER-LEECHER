Imports Microsoft.VisualBasic.CompilerServices
Imports System.ComponentModel
Imports System.IO
Imports System.Linq
Imports System.Net
Imports System.Runtime.CompilerServices
Imports System.Text
Imports System.Text.RegularExpressions
Imports System.Threading
Imports xNet


' SLAYER Leecher
' Made By X-SLAYER with Love (Tunisia,Sousse)
' First Version was released on 06/10/2016 11:45 AM
' Source code posted by X-SLAYER on 19/12/2021  01:00 AM ( after 5 years)  😭  😭 
' My Telegram : t.me/SLAYERS404

' When I wote this code, only god and
' I knew how it worked.
' Now, only god knows it!


Public Class Form1
#Region "other var"
    Private ReadOnly UAList As String() = New String() {"Mozilla/4.0 (compatible; Intel Mac OS X 10.6; rv:2.0b8) Gecko/20100101 Firefox/4.0b8)", "Mozilla/5.0 (Macintosh; I; Intel Mac OS X 11_7_9; de-LI; rv:1.9b4) Gecko/2012010317 Firefox/10.0a4", "Mozilla/5.0 (Macintosh; Intel Mac OS X 10.6; rv:2.0b11pre) Gecko/20110126 Firefox/4.0b11pre", "Mozilla/5.0 (Macintosh; Intel Mac OS X 10.6; rv:2.0b8) Gecko/20100101 Firefox/4.0b8", "Mozilla/5.0 (Macintosh; Intel Mac OS X 10.6; rv:25.0) Gecko/20100101 Firefox/25.0", "Mozilla/5.0 (Macintosh; Intel Mac OS X 10.6; rv:9.0) Gecko/20100101 Firefox/9.0", "Mozilla/5.0 (Macintosh; Intel Mac OS X 10.6; rv:9.0a2) Gecko/20111101 Firefox/9.0a2", "Mozilla/5.0 (Macintosh; Intel Mac OS X 10.8; rv:21.0) Gecko/20100101 Firefox/21.0", "Mozilla/5.0 (Macintosh; Intel Mac OS X 10.8; rv:24.0) Gecko/20100101 Firefox/24.0", "Mozilla/5.0 (Macintosh; Intel Mac OS X 10_10; rv:33.0) Gecko/20100101 Firefox/33.0", "Mozilla/5.0 (Macintosh; U; Intel Mac OS X 10.5; en-US; rv:1.9.2.4) Gecko/20100527 Firefox/3.6.4", "Mozilla/5.0 (Macintosh; U; Intel Mac OS X 10.6; en-US; rv:1.9.2) Gecko/20091218 Firefox 3.6b5", "Mozilla/5.0 (Macintosh; U; Intel Mac OS X 10.6;en-US; rv:1.9.2.9) Gecko/20100824 Firefox/3.6.9", "Mozilla/5.0 (Macintosh; U; Intel Mac OS X; de-AT; rv:1.9.1.8) Gecko/20100625 Firefox/3.6.6", "Mozilla/5.0 (Macintosh; U; PPC Mac OS X 10.5; en-US; rv:1.9.2.4) Gecko/20100611 Firefox/3.6.4 GTB7.0", "Mozilla/5.0 (Microsoft Windows NT 6.2.9200.0); rv:22.0) Gecko/20130405 Firefox/22.0", "Mozilla/5.0 (Windows NT 5.0; WOW64; rv:5.0) Gecko/20100101 Firefox/5.0", "Mozilla/5.0 (Windows NT 5.0; WOW64; rv:6.0) Gecko/20100101 Firefox/6.0", "Mozilla/5.0 (Windows NT 5.0; rv:21.0) Gecko/20100101 Firefox/21.0", "Mozilla/5.0 (Windows NT 5.0; rv:5.0) Gecko/20100101 Firefox/5.0", "Mozilla/5.0 (Windows NT 5.1; U; rv:5.0) Gecko/20100101 Firefox/5.0", "Mozilla/5.0 (Windows NT 5.1; rv:11.0) Gecko Firefox/11.0", "Mozilla/5.0 (Windows NT 5.1; rv:12.0) Gecko/20120403211507 Firefox/12.0", "Mozilla/5.0 (Windows NT 5.1; rv:14.0) Gecko/20120405 Firefox/14.0a1", "Mozilla/5.0 (Windows NT 5.1; rv:15.0) Gecko/20100101 Firefox/13.0.1", "Mozilla/5.0 (Windows NT 5.1; rv:2.0.1) Gecko/20100101 Firefox/5.0", "Mozilla/5.0 (Windows NT 5.1; rv:2.0b13pre) Gecko/20110223 Firefox/4.0b13pre", "Mozilla/5.0 (Windows NT 5.1; rv:2.0b8pre) Gecko/20101127 Firefox/4.0b8pre", "Mozilla/5.0 (Windows NT 5.1; rv:2.0b9pre) Gecko/20110105 Firefox/4.0b9pre", "Mozilla/5.0 (Windows NT 5.1; rv:21.0) Gecko/20100101 Firefox/21.0", "Mozilla/5.0 (Windows NT 5.1; rv:21.0) Gecko/20130331 Firefox/21.0", "Mozilla/5.0 (Windows NT 5.1; rv:21.0) Gecko/20130401 Firefox/21.0", "Mozilla/5.0 (Windows NT 5.1; rv:31.0) Gecko/20100101 Firefox/31.0", "Mozilla/5.0 (Windows NT 5.1; rv:6.0) Gecko/20100101 Firefox/6.0 FirePHP/0.6", "Mozilla/5.0 (Windows NT 5.1; rv:8.0; en_us) Gecko/20100101 Firefox/8.0", "Mozilla/5.0 (Windows NT 5.2; WOW64; rv:5.0) Gecko/20100101 Firefox/5.0", "Mozilla/5.0 (Windows NT 5.2; rv:2.0b13pre) Gecko/20110304 Firefox/4.0b13pre", "Mozilla/5.0 (Windows NT 6.0; WOW64; rv:24.0) Gecko/20100101 Firefox/24.0", "Mozilla/5.0 (Windows NT 6.0; rv:14.0) Gecko/20100101 Firefox/14.0.1", "Mozilla/5.0 (Windows NT 6.1.1; rv:5.0) Gecko/20100101 Firefox/5.0", "Mozilla/5.0 (Windows NT 6.1; U; ru; rv:5.0.1.6) Gecko/20110501 Firefox/5.0.1 Firefox/5.0.1", "Mozilla/5.0 (Windows NT 6.1; U;WOW64; de;rv:11.0) Gecko Firefox/11.0", "Mozilla/5.0 (Windows NT 6.1; WOW64; rv:11.0) Gecko Firefox/11.0", "Mozilla/5.0 (Windows NT 6.1; WOW64; rv:15.0) Gecko/20120427 Firefox/15.0a1", "Mozilla/5.0 (Windows NT 6.1; WOW64; rv:18.0) Gecko/20100101 Firefox/18.0", "Mozilla/5.0 (Windows NT 6.1; WOW64; rv:2.0b11pre) Gecko/20110128 Firefox/4.0b11pre", "Mozilla/5.0 (Windows NT 6.1; WOW64; rv:2.0b6pre) Gecko/20100903 Firefox/4.0b6pre", "Mozilla/5.0 (Windows NT 6.1; WOW64; rv:2.0b7) Gecko/20100101 Firefox/4.0b7", "Mozilla/5.0 (Windows NT 6.1; WOW64; rv:2.0b7) Gecko/20101111 Firefox/4.0b7", "Mozilla/5.0 (Windows NT 6.1; WOW64; rv:2.0b8pre) Gecko/20101114 Firefox/4.0b8pre", "Mozilla/5.0 (Windows NT 6.1; WOW64; rv:21.0) Gecko/20100101 Firefox/21.0", "Mozilla/5.0 (Windows NT 6.1; WOW64; rv:21.0) Gecko/20130330 Firefox/21.0", "Mozilla/5.0 (Windows NT 6.1; WOW64; rv:21.0) Gecko/20130331 Firefox/21.0", "Mozilla/5.0 (Windows NT 6.1; WOW64; rv:21.0) Gecko/20130401 Firefox/21.0", "Mozilla/5.0 (Windows NT 6.1; WOW64; rv:23.0) Gecko/20130406 Firefox/23.0", "Mozilla/5.0 (Windows NT 6.1; WOW64; rv:29.0) Gecko/20120101 Firefox/29.0", "Mozilla/5.0 (Windows NT 6.1; WOW64; rv:31.0) Gecko/20130401 Firefox/31.0", "Mozilla/5.0 (Windows NT 6.1; WOW64; rv:40.0) Gecko/20100101 Firefox/40.1", "Mozilla/5.0 (Windows NT 6.1; WOW64; rv:6.0a2) Gecko/20110612 Firefox/6.0a2", "Mozilla/5.0 (Windows NT 6.1; WOW64; rv:6.0a2) Gecko/20110613 Firefox/6.0a2", "Mozilla/5.0 (Windows NT 6.1; Win64; x64; rv:14.0) Gecko/20120405 Firefox/14.0a1", "Mozilla/5.0 (Windows NT 6.1; Win64; x64; rv:16.0.1) Gecko/20121011 Firefox/21.0.1", "Mozilla/5.0 (Windows NT 6.1; Win64; x64; rv:2.0b10pre) Gecko/20110118 Firefox/4.0b10pre", "Mozilla/5.0 (Windows NT 6.1; Win64; x64; rv:2.0b11pre) Gecko/20110128 Firefox/4.0b11pre", "Mozilla/5.0 (Windows NT 6.1; Win64; x64; rv:2.0b11pre) Gecko/20110129 Firefox/4.0b11pre", "Mozilla/5.0 (Windows NT 6.1; Win64; x64; rv:2.0b11pre) Gecko/20110131 Firefox/4.0b11pre", "Mozilla/5.0 (Windows NT 6.1; Win64; x64; rv:2.0b8pre) Gecko/20101114 Firefox/4.0b8pre", "Mozilla/5.0 (Windows NT 6.1; Win64; x64; rv:2.0b8pre) Gecko/20101128 Firefox/4.0b8pre", "Mozilla/5.0 (Windows NT 6.1; Win64; x64; rv:2.0b8pre) Gecko/20101213 Firefox/4.0b8pre", "Mozilla/5.0 (Windows NT 6.1; Win64; x64; rv:2.0b9pre) Gecko/20101228 Firefox/4.0b9pre", "Mozilla/5.0 (Windows NT 6.1; Win64; x64; rv:2.2a1pre) Gecko/20110208 Firefox/4.2a1pre", "Mozilla/5.0 (Windows NT 6.1; Win64; x64; rv:2.2a1pre) Gecko/20110323 Firefox/4.2a1pre", "Mozilla/5.0 (Windows NT 6.1; Win64; x64; rv:2.2a1pre) Gecko/20110324 Firefox/4.2a1pre", "Mozilla/5.0 (Windows NT 6.1; Win64; x64; rv:22.0) Gecko/20130328 Firefox/22.0", "Mozilla/5.0 (Windows NT 6.1; Win64; x64; rv:23.0) Gecko/20131011 Firefox/23.0", "Mozilla/5.0 (Windows NT 6.1; Win64; x64; rv:25.0) Gecko/20100101 Firefox/25.0", "Mozilla/5.0 (Windows NT 6.1; Win64; x64; rv:25.0) Gecko/20100101 Firefox/29.0", "Mozilla/5.0 (Windows NT 6.1; Win64; x64; rv:5.0) Gecko/20100101 Firefox/5.0", "Mozilla/5.0 (Windows NT 6.1; Win64; x64; rv:5.0) Gecko/20110619 Firefox/5.0", "Mozilla/5.0 (Windows NT 6.1; de;rv:12.0) Gecko/20120403211507 Firefox/12.0", "Mozilla/5.0 (Windows NT 6.1; rv:1.9) Gecko/20100101 Firefox/4.0", "Mozilla/5.0 (Windows NT 6.1; rv:12.0) Gecko/ 20120405 Firefox/14.0.1", "Mozilla/5.0 (Windows NT 6.1; rv:12.0) Gecko/20120403211507 Firefox/12.0", "Mozilla/5.0 (Windows NT 6.1; rv:12.0) Gecko/20120403211507 Firefox/14.0.1", "Mozilla/5.0 (Windows NT 6.1; rv:14.0) Gecko/20100101 Firefox/18.0.1", "Mozilla/5.0 (Windows NT 6.1; rv:14.0) Gecko/20120405 Firefox/14.0a1", "Mozilla/5.0 (Windows NT 6.1; rv:15.0) Gecko/20120716 Firefox/15.0a2", "Mozilla/5.0 (Windows NT 6.1; rv:2.0) Gecko/20110319 Firefox/4.0", "Mozilla/5.0 (Windows NT 6.1; rv:2.0b10) Gecko/20110126 Firefox/4.0b10", "Mozilla/5.0 (Windows NT 6.1; rv:2.0b10pre) Gecko/20110113 Firefox/4.0b10pre", "Mozilla/5.0 (Windows NT 6.1; rv:2.0b11pre) Gecko/20110126 Firefox/4.0b11pre", "Mozilla/5.0 (Windows NT 6.1; rv:2.0b6pre) Gecko/20100903 Firefox/4.0b6pre Firefox/4.0b6pre", "Mozilla/5.0 (Windows NT 6.1; rv:2.0b7pre) Gecko/20100921 Firefox/4.0b7pre", "Mozilla/5.0 (Windows NT 6.1; rv:21.0) Gecko/20100101 Firefox/21.0", "Mozilla/5.0 (Windows NT 6.1; rv:21.0) Gecko/20130328 Firefox/21.0", "Mozilla/5.0 (Windows NT 6.1; rv:21.0) Gecko/20130401 Firefox/21.0", "Mozilla/5.0 (Windows NT 6.1; rv:22.0) Gecko/20130405 Firefox/22.0", "Mozilla/5.0 (Windows NT 6.1; rv:27.3) Gecko/20130101 Firefox/27.3", "Mozilla/5.0 (Windows NT 6.1; rv:6.0) Gecko/20100101 Firefox/19.0", "Mozilla/5.0 (Windows NT 6.1; rv:6.0) Gecko/20100101 Firefox/5.0", "Mozilla/5.0 (Windows NT 6.1; rv:6.0) Gecko/20100101 Firefox/7.0", "Mozilla/5.0 (Windows NT 6.1; rv:6.0) Gecko/20110814 Firefox/6.0", "Mozilla/5.0 (Windows NT 6.2; WOW64; rv:15.0) Gecko/20120910144328 Firefox/15.0.2", "Mozilla/5.0 (Windows NT 6.2; WOW64; rv:16.0.1) Gecko/20121011 Firefox/16.0.1", "Mozilla/5.0 (Windows NT 6.2; WOW64; rv:21.0) Gecko/20130514 Firefox/21.0", "Mozilla/5.0 (Windows NT 6.2; WOW64; rv:5.0) Gecko/20100101 Firefox/5.0", "Mozilla/5.0 (Windows NT 6.2; Win64; x64; rv:16.0.1) Gecko/20121011 Firefox/16.0.1", "Mozilla/5.0 (Windows NT 6.2; Win64; x64; rv:16.0.1) Gecko/20121011 Firefox/21.0.1", "Mozilla/5.0 (Windows NT 6.2; Win64; x64; rv:21.0.0) Gecko/20121011 Firefox/21.0.0", "Mozilla/5.0 (Windows NT 6.2; Win64; x64; rv:27.0) Gecko/20121011 Firefox/27.0", "Mozilla/5.0 (Windows NT 6.2; Win64; x64;) Gecko/20100101 Firefox/20.0", "Mozilla/5.0 (Windows NT 6.2; rv:21.0) Gecko/20130326 Firefox/21.0", "Mozilla/5.0 (Windows NT 6.2; rv:22.0) Gecko/20130405 Firefox/22.0", "Mozilla/5.0 (Windows NT 6.2; rv:22.0) Gecko/20130405 Firefox/23.0", "Mozilla/5.0 (Windows NT 6.2; rv:9.0.1) Gecko/20100101 Firefox/9.0.1", "Mozilla/5.0 (Windows NT 6.3; rv:36.0) Gecko/20100101 Firefox/36.0", "Mozilla/5.0 (Windows x86; rv:19.0) Gecko/20100101 Firefox/19.0", "Mozilla/5.0 (Windows; U; Windows NT 5.1; cs; rv:1.9.2.4) Gecko/20100611 Firefox/3.6.4", "Mozilla/5.0 (Windows; U; Windows NT 5.1; en-US; rv:1.9.1.16) Gecko/20120427 Firefox/15.0a1", "Mozilla/5.0 (Windows; U; Windows NT 5.1; en-US; rv:1.9.2.28) Gecko/20120306 Firefox/5.0.1", "Mozilla/5.0 (Windows; U; Windows NT 5.1; en-US; rv:1.9.2.3) Gecko/20100401 Mozilla/5.0 (X11; U; Linux i686; it-IT; rv:1.9.0.2) Gecko/2008092313 Ubuntu/9.25 (jaunty) Firefox/3.8", "Mozilla/5.0 (Windows; U; Windows NT 5.1; en-US; rv:1.9.2b4) Gecko/20091124 Firefox/3.6b4", "Mozilla/5.0 (Windows; U; Windows NT 5.1; en-US; rv:2.0.1) Gecko/20110606 Firefox/4.0.1", "Mozilla/5.0 (Windows; U; Windows NT 5.1; fr; rv:1.9.2b4) Gecko/20091124 Firefox/3.6b4 (.NET CLR 3.5.30729)", "Mozilla/5.0 (Windows; U; Windows NT 5.1; fr; rv:1.9.2b5) Gecko/20091204 Firefox/3.6b5", "Mozilla/5.0 (Windows; U; Windows NT 5.1; it; rv:1.9.2.6) Gecko/20100625 Firefox/3.6.6 ( .NET CLR 3.5.30729; .NET4.0E)", "Mozilla/5.0 (Windows; U; Windows NT 5.1; ja; rv:1.9.2a1pre) Gecko/20090402 Firefox/3.6a1pre (.NET CLR 3.5.30729)", "Mozilla/5.0 (Windows; U; Windows NT 5.1; ko; rv:1.9.2.4) Gecko/20100523 Firefox/3.6.4", "Mozilla/5.0 (Windows; U; Windows NT 5.1; nb-NO; rv:1.9.2.4) Gecko/20100611 Firefox/3.6.4 (.NET CLR 3.5.30729)", "Mozilla/5.0 (Windows; U; Windows NT 5.1; pt-PT; rv:1.9.2.7) Gecko/20100713 Firefox/3.6.7 (.NET CLR 3.5.30729)", "Mozilla/5.0 (Windows; U; Windows NT 5.1; ru; rv:1.9.2.8) Gecko/20100722 Firefox/3.6.7 (.NET CLR 3.5.30729)", "Mozilla/5.0 (Windows; U; Windows NT 5.1; rv:15.0) Gecko/20121011 Firefox/15.0.1", "Mozilla/5.0 (Windows; U; Windows NT 5.1; tr; rv:1.9.2.8) Gecko/20100722 Firefox/3.6.8 ( .NET CLR 3.5.30729; .NET4.0E)", "Mozilla/5.0 (Windows; U; Windows NT 5.1; zh-CN; rv:1.9.2.4) Gecko/20100503 Firefox/3.6.4 ( .NET CLR 3.5.30729)", "Mozilla/5.0 (Windows; U; Windows NT 5.1; zh-CN; rv:1.9.2.4) Gecko/20100513 Firefox/3.6.4 (.NET CLR 3.5.30729)", "Mozilla/5.0 (Windows; U; Windows NT 5.1; zh-CN; rv:1.9.2.8) Gecko/20100722 Firefox/3.6.8", "Mozilla/5.0 (Windows; U; Windows NT 5.1; zh-TW; rv:1.9.2.4) Gecko/20100611 Firefox/3.6.4 GTB7.0 ( .NET CLR 3.5.30729)", "Mozilla/5.0 (Windows; U; Windows NT 5.2; en-CA; rv:1.9.2.4) Gecko/20100523 Firefox/3.6.4", "Mozilla/5.0 (Windows; U; Windows NT 5.2; en-GB; rv:1.9.2.9) Gecko/20100824 Firefox/3.6.9", "Mozilla/5.0 (Windows; U; Windows NT 5.2; zh-TW; rv:1.9.2.8) Gecko/20100722 Firefox/3.6.8", "Mozilla/5.0 (Windows; U; Windows NT 6.0; en-GB; rv:1.9.2.9) Gecko/20100824 Firefox/3.6.9 ( .NET CLR 3.5.30729; .NET CLR 4.0.20506)", "Mozilla/5.0 (Windows; U; Windows NT 6.0; en-US; rv:1.9.2.4) Gecko/20100513 Firefox/3.6.4 (.NET CLR 3.5.30729)", "Mozilla/5.0 (Windows; U; Windows NT 6.0; en-US; rv:1.9.2.4) Gecko/20100523 Firefox/3.6.4 ( .NET CLR 3.5.30729)", "Mozilla/5.0 (Windows; U; Windows NT 6.0; en-US; rv:1.9.2.4) Gecko/20100527 Firefox/3.6.4", "Mozilla/5.0 (Windows; U; Windows NT 6.0; en-US; rv:1.9.2.4) Gecko/20100527 Firefox/3.6.4 (.NET CLR 3.5.30729)", "Mozilla/5.0 (Windows; U; Windows NT 6.0; fr; rv:1.9.2.4) Gecko/20100523 Firefox/3.6.4 ( .NET CLR 3.5.30729)", "Mozilla/5.0 (Windows; U; Windows NT 6.0; ja; rv:1.9.2.4) Gecko/20100513 Firefox/3.6.4 ( .NET CLR 3.5.30729)", "Mozilla/5.0 (Windows; U; Windows NT 6.0; nl; rv:1.9.2.6) Gecko/20100625 Firefox/3.6.6", "Mozilla/5.0 (Windows; U; Windows NT 6.0; zh-CN; rv:1.9.2.4) Gecko/20100513 Firefox/3.6.4", "Mozilla/5.0 (Windows; U; Windows NT 6.0; zh-CN; rv:1.9.2.6) Gecko/20100625 Firefox/3.6.6 GTB7.1", "Mozilla/5.0 (Windows; U; Windows NT 6.1; WOW64; en-US; rv:2.0.4) Gecko/20120718 AskTbAVR-IDW/3.12.5.17700 Firefox/14.0.1", "Mozilla/5.0 (Windows; U; Windows NT 6.1; cs; rv:1.9.2.4) Gecko/20100513 Firefox/3.6.4 (.NET CLR 3.5.30729)", "Mozilla/5.0 (Windows; U; Windows NT 6.1; de; rv:1.9.2.3) Gecko/20121221 Firefox/3.6.8", "Mozilla/5.0 (Windows; U; Windows NT 6.1; de; rv:1.9.2.8) Gecko/20100722 Firefox 3.6.8", "Mozilla/5.0 (Windows; U; Windows NT 6.1; en-GB; rv:1.9.2.8) Gecko/20100722 Firefox/3.6.8 ( .NET CLR 3.5.30729; .NET4.0C)", "Mozilla/5.0 (Windows; U; Windows NT 6.1; en-US; rv:1.9.2.6) Gecko/20100625 Firefox/3.6.6 (.NET CLR 3.5.30729)", "Mozilla/5.0 (Windows; U; Windows NT 6.1; en-US; rv:1.9.2b1) Gecko/20091014 Firefox/3.6b1 GTB5", "Mozilla/5.0 (Windows; U; Windows NT 6.1; en-US; rv:1.9.2b5) Gecko/20091204 Firefox/3.6b5", "Mozilla/5.0 (Windows; U; Windows NT 6.1; en-US; rv:2.0b10) Gecko/20110126 Firefox/4.0b10", "Mozilla/5.0 (Windows; U; Windows NT 6.1; fr; rv:1.9.2.8) Gecko/20100722 Firefox 3.6.8 GTB7.1", "Mozilla/5.0 (Windows; U; Windows NT 6.1; he; rv:1.9.2.8) Gecko/20100722 Firefox/3.6.8", "Mozilla/5.0 (Windows; U; Windows NT 6.1; hu; rv:1.9.2.7) Gecko/20100713 Firefox/3.6.7 GTB7.1", "Mozilla/5.0 (Windows; U; Windows NT 6.1; it; rv:1.9.2.6) Gecko/20100625 Firefox/3.6.6 ( .NET CLR 3.5.30729)", "Mozilla/5.0 (Windows; U; Windows NT 6.1; it; rv:1.9.2.8) Gecko/20100722 AskTbADAP/3.9.1.14019 Firefox/3.6.8", "Mozilla/5.0 (Windows; U; Windows NT 6.1; ja; rv:1.9.2.4) Gecko/20100611 Firefox/3.6.4 GTB7.1", "Mozilla/5.0 (Windows; U; Windows NT 6.1; pt-BR; rv:1.9.2.8) Gecko/20100722 Firefox/3.6.8 GTB7.1", "Mozilla/5.0 (Windows; U; Windows NT 6.1; pt-PT; rv:1.9.2.6) Gecko/20100625 Firefox/3.6.6", "Mozilla/5.0 (Windows; U; Windows NT 6.1; ru; rv:1.9.2.3) Gecko/20100401 Firefox/4.0 (.NET CLR 3.5.30729)", "Mozilla/5.0 (Windows; U; Windows NT 6.1; ru; rv:1.9.2.4) Gecko/20100513 Firefox/3.6.4", "Mozilla/5.0 (Windows; U; Windows NT 6.1; ru; rv:1.9.2b5) Gecko/20091204 Firefox/3.6b5", "Mozilla/5.0 (Windows; U; Windows NT 6.1; rv:1.9.2.9) Gecko/20100913 Firefox/3.6.9", "Mozilla/5.0 (Windows; U; Windows NT 6.1; zh-CN; rv:1.9.2.8) Gecko/20100722 Firefox/3.6.8", "Mozilla/5.0 (Windows; U; Windows NT 6.1; zh-TW; rv:1.9.2.4) Gecko/20100611 Firefox/3.6.4 ( .NET CLR 3.5.30729)", "Mozilla/5.0 (Windows; Windows NT 5.1; en-US; rv:1.9.2a1pre) Gecko/20090402 Firefox/3.6a1pre", "Mozilla/5.0 (Windows; Windows NT 5.1; es-ES; rv:1.9.2a1pre) Gecko/20090402 Firefox/3.6a1pre", "Mozilla/5.0 (X11; Arch Linux i686; rv:2.0) Gecko/20110321 Firefox/4.0", "Mozilla/5.0 (X11; FreeBSD amd64; rv:5.0) Gecko/20100101 Firefox/5.0", "Mozilla/5.0 (X11; Linux AMD64) Gecko Firefox/5.0", "Mozilla/5.0 (X11; Linux i586; rv:31.0) Gecko/20100101 Firefox/31.0", "Mozilla/5.0 (X11; Linux i686 on x86_64; rv:5.0a2) Gecko/20110524 Firefox/5.0a2", "Mozilla/5.0 (X11; Linux i686; rv:2.0.1) Gecko/20110518 Firefox/4.0.1", "Mozilla/5.0 (X11; Linux i686; rv:2.0b10) Gecko/20100101 Firefox/4.0b10", "Mozilla/5.0 (X11; Linux i686; rv:2.0b12pre) Gecko/20100101 Firefox/4.0b12pre", "Mozilla/5.0 (X11; Linux i686; rv:2.0b12pre) Gecko/20110204 Firefox/4.0b12pre", "Mozilla/5.0 (X11; Linux i686; rv:2.0b3pre) Gecko/20100731 Firefox/4.0b3pre", "Mozilla/5.0 (X11; Linux i686; rv:21.0) Gecko/20100101 Firefox/21.0", "Mozilla/5.0 (X11; Linux i686; rv:6.0) Gecko/20100101 Firefox/6.0", "Mozilla/5.0 (X11; Linux ppc; rv:5.0) Gecko/20100101 Firefox/5.0", "Mozilla/5.0 (X11; Linux x86_64) Gecko Firefox/5.0", "Mozilla/5.0 (X11; Linux x86_64; rv:2.0.1) Gecko/20110506 Firefox/4.0.1", "Mozilla/5.0 (X11; Linux x86_64; rv:2.0b4) Gecko/20100818 Firefox/4.0b4", "Mozilla/5.0 (X11; Linux x86_64; rv:2.0b9pre) Gecko/20110111 Firefox/4.0b9pre", "Mozilla/5.0 (X11; Linux x86_64; rv:2.2a1pre) Gecko/20100101 Firefox/4.2a1pre", "Mozilla/5.0 (X11; Linux x86_64; rv:2.2a1pre) Gecko/20110324 Firefox/4.2a1pre", "Mozilla/5.0 (X11; Linux x86_64; rv:28.0) Gecko/20100101 Firefox/28.0", "Mozilla/5.0 (X11; Linux x86_64; rv:5.0) Gecko/20100101 Firefox/5.0 FirePHP/0.5", "Mozilla/5.0 (X11; Linux x86_64; rv:5.0) Gecko/20100101 Firefox/5.0 Firefox/5.0", "Mozilla/5.0 (X11; Linux) Gecko Firefox/5.0", "Mozilla/5.0 (X11; Mageia; Linux x86_64; rv:10.0.9) Gecko/20100101 Firefox/10.0.9", "Mozilla/5.0 (X11; NetBSD amd64; rv:16.0) Gecko/20121102 Firefox/16.0", "Mozilla/5.0 (X11; OpenBSD amd64; rv:28.0) Gecko/20100101 Firefox/28.0", "Mozilla/5.0 (X11; U; FreeBSD i386; de-CH; rv:1.9.2.8) Gecko/20100729 Firefox/3.6.8", "Mozilla/5.0 (X11; U; FreeBSD i386; en-US; rv:1.9.2.9) Gecko/20100913 Firefox/3.6.9", "Mozilla/5.0 (X11; U; Linux amd64; en-US; rv:5.0) Gecko/20110619 Firefox/5.0", "Mozilla/5.0 (X11; U; Linux amd64; rv:5.0) Gecko/20100101 Firefox/5.0 (Debian)", "Mozilla/5.0 (X11; U; Linux i586; de; rv:5.0) Gecko/20100101 Firefox/5.0", "Mozilla/5.0 (X11; U; Linux i686; de-DE; rv:1.9.2.8) Gecko/20100725 Gentoo Firefox/3.6.8", "Mozilla/5.0 (X11; U; Linux i686; en-GB; rv:2.0) Gecko/20110404 Fedora/16-dev Firefox/4.0", "Mozilla/5.0 (X11; U; Linux i686; en-US; rv:1.9.1.16) Gecko/20120421 Firefox/11.0", "Mozilla/5.0 (X11; U; Linux i686; en-US; rv:1.9.1.16) Gecko/20120421 Gecko Firefox/11.0", "Mozilla/5.0 (X11; U; Linux i686; en-US; rv:1.9.2.4) Gecko/20100625 Gentoo Firefox/3.6.4", "Mozilla/5.0 (X11; U; Linux i686; en-US; rv:1.9.2.7) Gecko/20100726 CentOS/3.6-3.el5.centos Firefox/3.6.7", "Mozilla/5.0 (X11; U; Linux i686; en-US; rv:1.9.2.8) Gecko/20100727 Firefox/3.6.8", "Mozilla/5.0 (X11; U; Linux i686; en-US; rv:1.9.2.9) Gecko/20100827 Red Hat/3.6.9-2.el6 Firefox/3.6.9", "Mozilla/5.0 (X11; U; Linux i686; fa; rv:1.8.1.4) Gecko/20100527 Firefox/3.6.4", "Mozilla/5.0 (X11; U; Linux i686; fi-FI; rv:1.9.2.8) Gecko/20100723 Ubuntu/10.04 (lucid) Firefox/3.6.8", "Mozilla/5.0 (X11; U; Linux i686; it-IT; rv:1.9.0.2) Gecko/2008092313 Ubuntu/9.25 (jaunty) Firefox/3.8", "Mozilla/5.0 (X11; U; Linux i686; pl-PL; rv:1.9.0.2) Gecko/2008092313 Ubuntu/9.25 (jaunty) Firefox/3.8", "Mozilla/5.0 (X11; U; Linux i686; pl-PL; rv:1.9.0.2) Gecko/20121223 Ubuntu/9.25 (jaunty) Firefox/3.8", "Mozilla/5.0 (X11; U; Linux i686; ru-RU; rv:1.9.2a1pre) Gecko/20090405 Ubuntu/9.04 (jaunty) Firefox/3.6a1pre", "Mozilla/5.0 (X11; U; Linux i686; ru; rv:1.9.1.3) Gecko/20091020 Ubuntu/10.04 (lucid) Firefox/4.0.1", "Mozilla/5.0 (X11; U; Linux i686; ru; rv:1.9.2.8) Gecko/20100723 Ubuntu/10.04 (lucid) Firefox/3.6.8", "Mozilla/5.0 (X11; U; Linux i686; ru; rv:1.9.3a5pre) Gecko/20100526 Firefox/3.7a5pre", "Mozilla/5.0 (X11; U; Linux i686; zh-CN; rv:1.9.2.8) Gecko/20100722 Ubuntu/10.04 (lucid) Firefox/3.6.8", "Mozilla/5.0 (X11; U; Linux x86_64; en-US; rv:1.9.2.4) Gecko/20100614 Ubuntu/10.04 (lucid) Firefox/3.6.4", "Mozilla/5.0 (X11; U; Linux x86_64; en-US; rv:1.9.2.6) Gecko/20100628 Ubuntu/10.04 (lucid) Firefox/3.6.6", "Mozilla/5.0 (X11; U; Linux x86_64; en-US; rv:1.9.2.6) Gecko/20100628 Ubuntu/10.04 (lucid) Firefox/3.6.6 (.NET CLR 3.5.30729)", "Mozilla/5.0 (X11; U; Linux x86_64; en-US; rv:1.9.2.6) Gecko/20100628 Ubuntu/10.04 (lucid) Firefox/3.6.6 GTB7.0", "Mozilla/5.0 (X11; U; Linux x86_64; en-US; rv:1.9.2.6) Gecko/20100628 Ubuntu/10.04 (lucid) Firefox/3.6.6 GTB7.1", "Mozilla/5.0 (X11; U; Linux x86_64; en-US; rv:1.9.2.7) Gecko/20100723 Fedora/3.6.7-1.fc13 Firefox/3.6.7", "Mozilla/5.0 (X11; U; Linux x86_64; en-US; rv:1.9.2.7) Gecko/20100809 Fedora/3.6.7-1.fc14 Firefox/3.6.7", "Mozilla/5.0 (X11; U; Linux x86_64; en-US; rv:1.9.2.8) Gecko/20100723 SUSE/3.6.8-0.1.1 Firefox/3.6.8", "Mozilla/5.0 (X11; U; Linux x86_64; en-US; rv:1.9.2.8) Gecko/20100804 Gentoo Firefox/3.6.8", "Mozilla/5.0 (X11; U; Linux x86_64; en-US; rv:1.9.2.9) Gecko/20100915 Gentoo Firefox/3.6.9", "Mozilla/5.0 (X11; U; Linux x86_64; en-US; rv:1.9.2a1pre) Gecko/20090405 Firefox/3.6a1pre", "Mozilla/5.0 (X11; U; Linux x86_64; en-US; rv:1.9.2a1pre) Gecko/20090428 Firefox/3.6a1pre", "Mozilla/5.0 (X11; U; Linux x86_64; pl-PL; rv:2.0) Gecko/20110307 Firefox/4.0", "Mozilla/5.0 (X11; U; OpenBSD i386; en-US; rv:1.9.2.8) Gecko/20101230 Firefox/3.6.8", "Mozilla/5.0 (X11; Ubuntu; Linux armv7l; rv:17.0) Gecko/20100101 Firefox/17.0", "Mozilla/5.0 (X11; Ubuntu; Linux i686; rv:14.0) Gecko/20100101 Firefox/14.0.1", "Mozilla/5.0 (X11; Ubuntu; Linux i686; rv:15.0) Gecko/20100101 Firefox/15.0.1", "Mozilla/5.0 (X11; Ubuntu; Linux x86_64; rv:14.0) Gecko/20100101 Firefox/14.0.1", "Mozilla/5.0 (X11; Ubuntu; Linux x86_64; rv:17.0) Gecko/20100101 Firefox/17.0.6", "Mozilla/5.0 (X11; Ubuntu; Linux x86_64; rv:21.0) Gecko/20100101 Firefox/21.0", "Mozilla/5.0 (X11; Ubuntu; Linux x86_64; rv:21.0) Gecko/20130331 Firefox/21.0", "Mozilla/5.0 (X11; Ubuntu; Linux x86_64; rv:24.0) Gecko/20100101 Firefox/24.0", "Mozilla/5.0 (compatible; Windows; U; Windows NT 6.2; WOW64; en-US; rv:12.0) Gecko/20120403211507 Firefox/12.0", "Mozilla/6.0 (Macintosh; I; Intel Mac OS X 11_7_9; de-LI; rv:1.9b4) Gecko/2012010317 Firefox/10.0a4", "Mozilla/6.0 (Windows NT 6.2; WOW64; rv:16.0.1) Gecko/20121011 Firefox/16.0.1", "Mozilla/3.0 (Windows NT 6.1; rv:2.0.1) Gecko/20100101 Firefox/5.0.1"}
    Public BO As Boolean
    Public Status As String
    Public Country As String
    Public countList As Integer
    Public countProxy As Integer
    Public countThreads As Integer
    Public goods As String() = New String(0 - 1) {}
    Public lines As Queue
    Public list As String()
    Public lockThis As Object = New Object
    Public proxyType As ProxyType
    Public proxy As String()
    Public rnd As Random = New Random
    Public Thread As Thread()
    Public object_0 As Object
    Public total_checked As Integer
    Public total_errors As Integer
    Public DAMN As String = "YES"
    Dim proxyAddress As String
#End Region
    '===================================================================
    Private a As Integer 'Counter
    Public Duréé As String = "d"  'Resultat Of last
    Dim Pitter As String = "[a-zA-Z0-9._%+-]+@(?:[a-zA-Z0-9-]+\.)+[a-zA-Z]{2,6}:(?:[a-zA-Z0-9]{5,})" 'Type Of Resultat
    Dim RES As HttpWebResponse
    Dim CON As New CookieContainer
    Dim ER As Integer = 0
    Dim CR As Integer = 0
    Public CODE As String() = New String() {"com", "ac", "fr", "tn", "ru"}
    Public Useragent As String() = New String() {"Mozilla/4.0 (compatible; Intel Mac OS X 10.6; rv:2.0b8) Gecko/20100101 Firefox/4.0b8)", "Mozilla/5.0 (Macintosh; I; Intel Mac OS X 11_7_9; de-LI; rv:1.9b4) Gecko/2012010317 Firefox/10.0a4", "Mozilla/5.0 (Macintosh; Intel Mac OS X 10.6; rv:2.0b11pre) Gecko/20110126 Firefox/4.0b11pre", "Mozilla/5.0 (Macintosh; Intel Mac OS X 10.6; rv:2.0b8) Gecko/20100101 Firefox/4.0b8", "Mozilla/5.0 (Macintosh; Intel Mac OS X 10.6; rv:25.0) Gecko/20100101 Firefox/25.0", "Mozilla/5.0 (Macintosh; Intel Mac OS X 10.6; rv:9.0) Gecko/20100101 Firefox/9.0", "Mozilla/5.0 (Macintosh; Intel Mac OS X 10.6; rv:9.0a2) Gecko/20111101 Firefox/9.0a2", "Mozilla/5.0 (Macintosh; Intel Mac OS X 10.8; rv:21.0) Gecko/20100101 Firefox/21.0", "Mozilla/5.0 (Macintosh; Intel Mac OS X 10.8; rv:24.0) Gecko/20100101 Firefox/24.0", "Mozilla/5.0 (Macintosh; Intel Mac OS X 10_10; rv:33.0) Gecko/20100101 Firefox/33.0", "Mozilla/5.0 (Macintosh; U; Intel Mac OS X 10.5; en-US; rv:1.9.2.4) Gecko/20100527 Firefox/3.6.4", "Mozilla/5.0 (Macintosh; U; Intel Mac OS X 10.6; en-US; rv:1.9.2) Gecko/20091218 Firefox 3.6b5", "Mozilla/5.0 (Macintosh; U; Intel Mac OS X 10.6;en-US; rv:1.9.2.9) Gecko/20100824 Firefox/3.6.9", "Mozilla/5.0 (Macintosh; U; Intel Mac OS X; de-AT; rv:1.9.1.8) Gecko/20100625 Firefox/3.6.6", "Mozilla/5.0 (Macintosh; U; PPC Mac OS X 10.5; en-US; rv:1.9.2.4) Gecko/20100611 Firefox/3.6.4 GTB7.0", "Mozilla/5.0 (Microsoft Windows NT 6.2.9200.0); rv:22.0) Gecko/20130405 Firefox/22.0", "Mozilla/5.0 (Windows NT 5.0; WOW64; rv:5.0) Gecko/20100101 Firefox/5.0", "Mozilla/5.0 (Windows NT 5.0; WOW64; rv:6.0) Gecko/20100101 Firefox/6.0", "Mozilla/5.0 (Windows NT 5.0; rv:21.0) Gecko/20100101 Firefox/21.0", "Mozilla/5.0 (Windows NT 5.0; rv:5.0) Gecko/20100101 Firefox/5.0", "Mozilla/5.0 (Windows NT 5.1; U; rv:5.0) Gecko/20100101 Firefox/5.0", "Mozilla/5.0 (Windows NT 5.1; rv:11.0) Gecko Firefox/11.0", "Mozilla/5.0 (Windows NT 5.1; rv:12.0) Gecko/20120403211507 Firefox/12.0", "Mozilla/5.0 (Windows NT 5.1; rv:14.0) Gecko/20120405 Firefox/14.0a1", "Mozilla/5.0 (Windows NT 5.1; rv:15.0) Gecko/20100101 Firefox/13.0.1", "Mozilla/5.0 (Windows NT 5.1; rv:2.0.1) Gecko/20100101 Firefox/5.0", "Mozilla/5.0 (Windows NT 5.1; rv:2.0b13pre) Gecko/20110223 Firefox/4.0b13pre", "Mozilla/5.0 (Windows NT 5.1; rv:2.0b8pre) Gecko/20101127 Firefox/4.0b8pre", "Mozilla/5.0 (Windows NT 5.1; rv:2.0b9pre) Gecko/20110105 Firefox/4.0b9pre", "Mozilla/5.0 (Windows NT 5.1; rv:21.0) Gecko/20100101 Firefox/21.0", "Mozilla/5.0 (Windows NT 5.1; rv:21.0) Gecko/20130331 Firefox/21.0", "Mozilla/5.0 (Windows NT 5.1; rv:21.0) Gecko/20130401 Firefox/21.0", "Mozilla/5.0 (Windows NT 5.1; rv:31.0) Gecko/20100101 Firefox/31.0", "Mozilla/5.0 (Windows NT 5.1; rv:6.0) Gecko/20100101 Firefox/6.0 FirePHP/0.6", "Mozilla/5.0 (Windows NT 5.1; rv:8.0; en_us) Gecko/20100101 Firefox/8.0", "Mozilla/5.0 (Windows NT 5.2; WOW64; rv:5.0) Gecko/20100101 Firefox/5.0", "Mozilla/5.0 (Windows NT 5.2; rv:2.0b13pre) Gecko/20110304 Firefox/4.0b13pre", "Mozilla/5.0 (Windows NT 6.0; WOW64; rv:24.0) Gecko/20100101 Firefox/24.0", "Mozilla/5.0 (Windows NT 6.0; rv:14.0) Gecko/20100101 Firefox/14.0.1", "Mozilla/5.0 (Windows NT 6.1.1; rv:5.0) Gecko/20100101 Firefox/5.0", "Mozilla/5.0 (Windows NT 6.1; U; ru; rv:5.0.1.6) Gecko/20110501 Firefox/5.0.1 Firefox/5.0.1", "Mozilla/5.0 (Windows NT 6.1; U;WOW64; de;rv:11.0) Gecko Firefox/11.0", "Mozilla/5.0 (Windows NT 6.1; WOW64; rv:11.0) Gecko Firefox/11.0", "Mozilla/5.0 (Windows NT 6.1; WOW64; rv:15.0) Gecko/20120427 Firefox/15.0a1", "Mozilla/5.0 (Windows NT 6.1; WOW64; rv:18.0) Gecko/20100101 Firefox/18.0", "Mozilla/5.0 (Windows NT 6.1; WOW64; rv:2.0b11pre) Gecko/20110128 Firefox/4.0b11pre", "Mozilla/5.0 (Windows NT 6.1; WOW64; rv:2.0b6pre) Gecko/20100903 Firefox/4.0b6pre", "Mozilla/5.0 (Windows NT 6.1; WOW64; rv:2.0b7) Gecko/20100101 Firefox/4.0b7", "Mozilla/5.0 (Windows NT 6.1; WOW64; rv:2.0b7) Gecko/20101111 Firefox/4.0b7", "Mozilla/5.0 (Windows NT 6.1; WOW64; rv:2.0b8pre) Gecko/20101114 Firefox/4.0b8pre", "Mozilla/5.0 (Windows NT 6.1; WOW64; rv:21.0) Gecko/20100101 Firefox/21.0", "Mozilla/5.0 (Windows NT 6.1; WOW64; rv:21.0) Gecko/20130330 Firefox/21.0", "Mozilla/5.0 (Windows NT 6.1; WOW64; rv:21.0) Gecko/20130331 Firefox/21.0", "Mozilla/5.0 (Windows NT 6.1; WOW64; rv:21.0) Gecko/20130401 Firefox/21.0", "Mozilla/5.0 (Windows NT 6.1; WOW64; rv:23.0) Gecko/20130406 Firefox/23.0", "Mozilla/5.0 (Windows NT 6.1; WOW64; rv:29.0) Gecko/20120101 Firefox/29.0", "Mozilla/5.0 (Windows NT 6.1; WOW64; rv:31.0) Gecko/20130401 Firefox/31.0", "Mozilla/5.0 (Windows NT 6.1; WOW64; rv:40.0) Gecko/20100101 Firefox/40.1", "Mozilla/5.0 (Windows NT 6.1; WOW64; rv:6.0a2) Gecko/20110612 Firefox/6.0a2", "Mozilla/5.0 (Windows NT 6.1; WOW64; rv:6.0a2) Gecko/20110613 Firefox/6.0a2", "Mozilla/5.0 (Windows NT 6.1; Win64; x64; rv:14.0) Gecko/20120405 Firefox/14.0a1", "Mozilla/5.0 (Windows NT 6.1; Win64; x64; rv:16.0.1) Gecko/20121011 Firefox/21.0.1", "Mozilla/5.0 (Windows NT 6.1; Win64; x64; rv:2.0b10pre) Gecko/20110118 Firefox/4.0b10pre", "Mozilla/5.0 (Windows NT 6.1; Win64; x64; rv:2.0b11pre) Gecko/20110128 Firefox/4.0b11pre", "Mozilla/5.0 (Windows NT 6.1; Win64; x64; rv:2.0b11pre) Gecko/20110129 Firefox/4.0b11pre", "Mozilla/5.0 (Windows NT 6.1; Win64; x64; rv:2.0b11pre) Gecko/20110131 Firefox/4.0b11pre", "Mozilla/5.0 (Windows NT 6.1; Win64; x64; rv:2.0b8pre) Gecko/20101114 Firefox/4.0b8pre", "Mozilla/5.0 (Windows NT 6.1; Win64; x64; rv:2.0b8pre) Gecko/20101128 Firefox/4.0b8pre", "Mozilla/5.0 (Windows NT 6.1; Win64; x64; rv:2.0b8pre) Gecko/20101213 Firefox/4.0b8pre", "Mozilla/5.0 (Windows NT 6.1; Win64; x64; rv:2.0b9pre) Gecko/20101228 Firefox/4.0b9pre", "Mozilla/5.0 (Windows NT 6.1; Win64; x64; rv:2.2a1pre) Gecko/20110208 Firefox/4.2a1pre", "Mozilla/5.0 (Windows NT 6.1; Win64; x64; rv:2.2a1pre) Gecko/20110323 Firefox/4.2a1pre", "Mozilla/5.0 (Windows NT 6.1; Win64; x64; rv:2.2a1pre) Gecko/20110324 Firefox/4.2a1pre", "Mozilla/5.0 (Windows NT 6.1; Win64; x64; rv:22.0) Gecko/20130328 Firefox/22.0", "Mozilla/5.0 (Windows NT 6.1; Win64; x64; rv:23.0) Gecko/20131011 Firefox/23.0", "Mozilla/5.0 (Windows NT 6.1; Win64; x64; rv:25.0) Gecko/20100101 Firefox/25.0", "Mozilla/5.0 (Windows NT 6.1; Win64; x64; rv:25.0) Gecko/20100101 Firefox/29.0", "Mozilla/5.0 (Windows NT 6.1; Win64; x64; rv:5.0) Gecko/20100101 Firefox/5.0", "Mozilla/5.0 (Windows NT 6.1; Win64; x64; rv:5.0) Gecko/20110619 Firefox/5.0", "Mozilla/5.0 (Windows NT 6.1; de;rv:12.0) Gecko/20120403211507 Firefox/12.0", "Mozilla/5.0 (Windows NT 6.1; rv:1.9) Gecko/20100101 Firefox/4.0", "Mozilla/5.0 (Windows NT 6.1; rv:12.0) Gecko/ 20120405 Firefox/14.0.1", "Mozilla/5.0 (Windows NT 6.1; rv:12.0) Gecko/20120403211507 Firefox/12.0", "Mozilla/5.0 (Windows NT 6.1; rv:12.0) Gecko/20120403211507 Firefox/14.0.1", "Mozilla/5.0 (Windows NT 6.1; rv:14.0) Gecko/20100101 Firefox/18.0.1", "Mozilla/5.0 (Windows NT 6.1; rv:14.0) Gecko/20120405 Firefox/14.0a1", "Mozilla/5.0 (Windows NT 6.1; rv:15.0) Gecko/20120716 Firefox/15.0a2", "Mozilla/5.0 (Windows NT 6.1; rv:2.0) Gecko/20110319 Firefox/4.0", "Mozilla/5.0 (Windows NT 6.1; rv:2.0b10) Gecko/20110126 Firefox/4.0b10", "Mozilla/5.0 (Windows NT 6.1; rv:2.0b10pre) Gecko/20110113 Firefox/4.0b10pre", "Mozilla/5.0 (Windows NT 6.1; rv:2.0b11pre) Gecko/20110126 Firefox/4.0b11pre", "Mozilla/5.0 (Windows NT 6.1; rv:2.0b6pre) Gecko/20100903 Firefox/4.0b6pre Firefox/4.0b6pre", "Mozilla/5.0 (Windows NT 6.1; rv:2.0b7pre) Gecko/20100921 Firefox/4.0b7pre", "Mozilla/5.0 (Windows NT 6.1; rv:21.0) Gecko/20100101 Firefox/21.0", "Mozilla/5.0 (Windows NT 6.1; rv:21.0) Gecko/20130328 Firefox/21.0", "Mozilla/5.0 (Windows NT 6.1; rv:21.0) Gecko/20130401 Firefox/21.0", "Mozilla/5.0 (Windows NT 6.1; rv:22.0) Gecko/20130405 Firefox/22.0", "Mozilla/5.0 (Windows NT 6.1; rv:27.3) Gecko/20130101 Firefox/27.3", "Mozilla/5.0 (Windows NT 6.1; rv:6.0) Gecko/20100101 Firefox/19.0", "Mozilla/5.0 (Windows NT 6.1; rv:6.0) Gecko/20100101 Firefox/5.0", "Mozilla/5.0 (Windows NT 6.1; rv:6.0) Gecko/20100101 Firefox/7.0", "Mozilla/5.0 (Windows NT 6.1; rv:6.0) Gecko/20110814 Firefox/6.0", "Mozilla/5.0 (Windows NT 6.2; WOW64; rv:15.0) Gecko/20120910144328 Firefox/15.0.2", "Mozilla/5.0 (Windows NT 6.2; WOW64; rv:16.0.1) Gecko/20121011 Firefox/16.0.1", "Mozilla/5.0 (Windows NT 6.2; WOW64; rv:21.0) Gecko/20130514 Firefox/21.0", "Mozilla/5.0 (Windows NT 6.2; WOW64; rv:5.0) Gecko/20100101 Firefox/5.0", "Mozilla/5.0 (Windows NT 6.2; Win64; x64; rv:16.0.1) Gecko/20121011 Firefox/16.0.1", "Mozilla/5.0 (Windows NT 6.2; Win64; x64; rv:16.0.1) Gecko/20121011 Firefox/21.0.1", "Mozilla/5.0 (Windows NT 6.2; Win64; x64; rv:21.0.0) Gecko/20121011 Firefox/21.0.0", "Mozilla/5.0 (Windows NT 6.2; Win64; x64; rv:27.0) Gecko/20121011 Firefox/27.0", "Mozilla/5.0 (Windows NT 6.2; Win64; x64;) Gecko/20100101 Firefox/20.0", "Mozilla/5.0 (Windows NT 6.2; rv:21.0) Gecko/20130326 Firefox/21.0", "Mozilla/5.0 (Windows NT 6.2; rv:22.0) Gecko/20130405 Firefox/22.0", "Mozilla/5.0 (Windows NT 6.2; rv:22.0) Gecko/20130405 Firefox/23.0", "Mozilla/5.0 (Windows NT 6.2; rv:9.0.1) Gecko/20100101 Firefox/9.0.1", "Mozilla/5.0 (Windows NT 6.3; rv:36.0) Gecko/20100101 Firefox/36.0", "Mozilla/5.0 (Windows x86; rv:19.0) Gecko/20100101 Firefox/19.0", "Mozilla/5.0 (Windows; U; Windows NT 5.1; cs; rv:1.9.2.4) Gecko/20100611 Firefox/3.6.4", "Mozilla/5.0 (Windows; U; Windows NT 5.1; en-US; rv:1.9.1.16) Gecko/20120427 Firefox/15.0a1", "Mozilla/5.0 (Windows; U; Windows NT 5.1; en-US; rv:1.9.2.28) Gecko/20120306 Firefox/5.0.1", "Mozilla/5.0 (Windows; U; Windows NT 5.1; en-US; rv:1.9.2.3) Gecko/20100401 Mozilla/5.0 (X11; U; Linux i686; it-IT; rv:1.9.0.2) Gecko/2008092313 Ubuntu/9.25 (jaunty) Firefox/3.8", "Mozilla/5.0 (Windows; U; Windows NT 5.1; en-US; rv:1.9.2b4) Gecko/20091124 Firefox/3.6b4", "Mozilla/5.0 (Windows; U; Windows NT 5.1; en-US; rv:2.0.1) Gecko/20110606 Firefox/4.0.1", "Mozilla/5.0 (Windows; U; Windows NT 5.1; fr; rv:1.9.2b4) Gecko/20091124 Firefox/3.6b4 (.NET CLR 3.5.30729)", "Mozilla/5.0 (Windows; U; Windows NT 5.1; fr; rv:1.9.2b5) Gecko/20091204 Firefox/3.6b5", "Mozilla/5.0 (Windows; U; Windows NT 5.1; it; rv:1.9.2.6) Gecko/20100625 Firefox/3.6.6 ( .NET CLR 3.5.30729; .NET4.0E)", "Mozilla/5.0 (Windows; U; Windows NT 5.1; ja; rv:1.9.2a1pre) Gecko/20090402 Firefox/3.6a1pre (.NET CLR 3.5.30729)", "Mozilla/5.0 (Windows; U; Windows NT 5.1; ko; rv:1.9.2.4) Gecko/20100523 Firefox/3.6.4", "Mozilla/5.0 (Windows; U; Windows NT 5.1; nb-NO; rv:1.9.2.4) Gecko/20100611 Firefox/3.6.4 (.NET CLR 3.5.30729)", "Mozilla/5.0 (Windows; U; Windows NT 5.1; pt-PT; rv:1.9.2.7) Gecko/20100713 Firefox/3.6.7 (.NET CLR 3.5.30729)", "Mozilla/5.0 (Windows; U; Windows NT 5.1; ru; rv:1.9.2.8) Gecko/20100722 Firefox/3.6.7 (.NET CLR 3.5.30729)", "Mozilla/5.0 (Windows; U; Windows NT 5.1; rv:15.0) Gecko/20121011 Firefox/15.0.1", "Mozilla/5.0 (Windows; U; Windows NT 5.1; tr; rv:1.9.2.8) Gecko/20100722 Firefox/3.6.8 ( .NET CLR 3.5.30729; .NET4.0E)", "Mozilla/5.0 (Windows; U; Windows NT 5.1; zh-CN; rv:1.9.2.4) Gecko/20100503 Firefox/3.6.4 ( .NET CLR 3.5.30729)", "Mozilla/5.0 (Windows; U; Windows NT 5.1; zh-CN; rv:1.9.2.4) Gecko/20100513 Firefox/3.6.4 (.NET CLR 3.5.30729)", "Mozilla/5.0 (Windows; U; Windows NT 5.1; zh-CN; rv:1.9.2.8) Gecko/20100722 Firefox/3.6.8", "Mozilla/5.0 (Windows; U; Windows NT 5.1; zh-TW; rv:1.9.2.4) Gecko/20100611 Firefox/3.6.4 GTB7.0 ( .NET CLR 3.5.30729)", "Mozilla/5.0 (Windows; U; Windows NT 5.2; en-CA; rv:1.9.2.4) Gecko/20100523 Firefox/3.6.4", "Mozilla/5.0 (Windows; U; Windows NT 5.2; en-GB; rv:1.9.2.9) Gecko/20100824 Firefox/3.6.9", "Mozilla/5.0 (Windows; U; Windows NT 5.2; zh-TW; rv:1.9.2.8) Gecko/20100722 Firefox/3.6.8", "Mozilla/5.0 (Windows; U; Windows NT 6.0; en-GB; rv:1.9.2.9) Gecko/20100824 Firefox/3.6.9 ( .NET CLR 3.5.30729; .NET CLR 4.0.20506)", "Mozilla/5.0 (Windows; U; Windows NT 6.0; en-US; rv:1.9.2.4) Gecko/20100513 Firefox/3.6.4 (.NET CLR 3.5.30729)", "Mozilla/5.0 (Windows; U; Windows NT 6.0; en-US; rv:1.9.2.4) Gecko/20100523 Firefox/3.6.4 ( .NET CLR 3.5.30729)", "Mozilla/5.0 (Windows; U; Windows NT 6.0; en-US; rv:1.9.2.4) Gecko/20100527 Firefox/3.6.4", "Mozilla/5.0 (Windows; U; Windows NT 6.0; en-US; rv:1.9.2.4) Gecko/20100527 Firefox/3.6.4 (.NET CLR 3.5.30729)", "Mozilla/5.0 (Windows; U; Windows NT 6.0; fr; rv:1.9.2.4) Gecko/20100523 Firefox/3.6.4 ( .NET CLR 3.5.30729)", "Mozilla/5.0 (Windows; U; Windows NT 6.0; ja; rv:1.9.2.4) Gecko/20100513 Firefox/3.6.4 ( .NET CLR 3.5.30729)", "Mozilla/5.0 (Windows; U; Windows NT 6.0; nl; rv:1.9.2.6) Gecko/20100625 Firefox/3.6.6", "Mozilla/5.0 (Windows; U; Windows NT 6.0; zh-CN; rv:1.9.2.4) Gecko/20100513 Firefox/3.6.4", "Mozilla/5.0 (Windows; U; Windows NT 6.0; zh-CN; rv:1.9.2.6) Gecko/20100625 Firefox/3.6.6 GTB7.1", "Mozilla/5.0 (Windows; U; Windows NT 6.1; WOW64; en-US; rv:2.0.4) Gecko/20120718 AskTbAVR-IDW/3.12.5.17700 Firefox/14.0.1", "Mozilla/5.0 (Windows; U; Windows NT 6.1; cs; rv:1.9.2.4) Gecko/20100513 Firefox/3.6.4 (.NET CLR 3.5.30729)", "Mozilla/5.0 (Windows; U; Windows NT 6.1; de; rv:1.9.2.3) Gecko/20121221 Firefox/3.6.8", "Mozilla/5.0 (Windows; U; Windows NT 6.1; de; rv:1.9.2.8) Gecko/20100722 Firefox 3.6.8", "Mozilla/5.0 (Windows; U; Windows NT 6.1; en-GB; rv:1.9.2.8) Gecko/20100722 Firefox/3.6.8 ( .NET CLR 3.5.30729; .NET4.0C)", "Mozilla/5.0 (Windows; U; Windows NT 6.1; en-US; rv:1.9.2.6) Gecko/20100625 Firefox/3.6.6 (.NET CLR 3.5.30729)", "Mozilla/5.0 (Windows; U; Windows NT 6.1; en-US; rv:1.9.2b1) Gecko/20091014 Firefox/3.6b1 GTB5", "Mozilla/5.0 (Windows; U; Windows NT 6.1; en-US; rv:1.9.2b5) Gecko/20091204 Firefox/3.6b5", "Mozilla/5.0 (Windows; U; Windows NT 6.1; en-US; rv:2.0b10) Gecko/20110126 Firefox/4.0b10", "Mozilla/5.0 (Windows; U; Windows NT 6.1; fr; rv:1.9.2.8) Gecko/20100722 Firefox 3.6.8 GTB7.1", "Mozilla/5.0 (Windows; U; Windows NT 6.1; he; rv:1.9.2.8) Gecko/20100722 Firefox/3.6.8", "Mozilla/5.0 (Windows; U; Windows NT 6.1; hu; rv:1.9.2.7) Gecko/20100713 Firefox/3.6.7 GTB7.1", "Mozilla/5.0 (Windows; U; Windows NT 6.1; it; rv:1.9.2.6) Gecko/20100625 Firefox/3.6.6 ( .NET CLR 3.5.30729)", "Mozilla/5.0 (Windows; U; Windows NT 6.1; it; rv:1.9.2.8) Gecko/20100722 AskTbADAP/3.9.1.14019 Firefox/3.6.8", "Mozilla/5.0 (Windows; U; Windows NT 6.1; ja; rv:1.9.2.4) Gecko/20100611 Firefox/3.6.4 GTB7.1", "Mozilla/5.0 (Windows; U; Windows NT 6.1; pt-BR; rv:1.9.2.8) Gecko/20100722 Firefox/3.6.8 GTB7.1", "Mozilla/5.0 (Windows; U; Windows NT 6.1; pt-PT; rv:1.9.2.6) Gecko/20100625 Firefox/3.6.6", "Mozilla/5.0 (Windows; U; Windows NT 6.1; ru; rv:1.9.2.3) Gecko/20100401 Firefox/4.0 (.NET CLR 3.5.30729)", "Mozilla/5.0 (Windows; U; Windows NT 6.1; ru; rv:1.9.2.4) Gecko/20100513 Firefox/3.6.4", "Mozilla/5.0 (Windows; U; Windows NT 6.1; ru; rv:1.9.2b5) Gecko/20091204 Firefox/3.6b5", "Mozilla/5.0 (Windows; U; Windows NT 6.1; rv:1.9.2.9) Gecko/20100913 Firefox/3.6.9", "Mozilla/5.0 (Windows; U; Windows NT 6.1; zh-CN; rv:1.9.2.8) Gecko/20100722 Firefox/3.6.8", "Mozilla/5.0 (Windows; U; Windows NT 6.1; zh-TW; rv:1.9.2.4) Gecko/20100611 Firefox/3.6.4 ( .NET CLR 3.5.30729)", "Mozilla/5.0 (Windows; Windows NT 5.1; en-US; rv:1.9.2a1pre) Gecko/20090402 Firefox/3.6a1pre", "Mozilla/5.0 (Windows; Windows NT 5.1; es-ES; rv:1.9.2a1pre) Gecko/20090402 Firefox/3.6a1pre", "Mozilla/5.0 (X11; Arch Linux i686; rv:2.0) Gecko/20110321 Firefox/4.0", "Mozilla/5.0 (X11; FreeBSD amd64; rv:5.0) Gecko/20100101 Firefox/5.0", "Mozilla/5.0 (X11; Linux AMD64) Gecko Firefox/5.0", "Mozilla/5.0 (X11; Linux i586; rv:31.0) Gecko/20100101 Firefox/31.0", "Mozilla/5.0 (X11; Linux i686 on x86_64; rv:5.0a2) Gecko/20110524 Firefox/5.0a2", "Mozilla/5.0 (X11; Linux i686; rv:2.0.1) Gecko/20110518 Firefox/4.0.1", "Mozilla/5.0 (X11; Linux i686; rv:2.0b10) Gecko/20100101 Firefox/4.0b10", "Mozilla/5.0 (X11; Linux i686; rv:2.0b12pre) Gecko/20100101 Firefox/4.0b12pre", "Mozilla/5.0 (X11; Linux i686; rv:2.0b12pre) Gecko/20110204 Firefox/4.0b12pre", "Mozilla/5.0 (X11; Linux i686; rv:2.0b3pre) Gecko/20100731 Firefox/4.0b3pre", "Mozilla/5.0 (X11; Linux i686; rv:21.0) Gecko/20100101 Firefox/21.0", "Mozilla/5.0 (X11; Linux i686; rv:6.0) Gecko/20100101 Firefox/6.0", "Mozilla/5.0 (X11; Linux ppc; rv:5.0) Gecko/20100101 Firefox/5.0", "Mozilla/5.0 (X11; Linux x86_64) Gecko Firefox/5.0", "Mozilla/5.0 (X11; Linux x86_64; rv:2.0.1) Gecko/20110506 Firefox/4.0.1", "Mozilla/5.0 (X11; Linux x86_64; rv:2.0b4) Gecko/20100818 Firefox/4.0b4", "Mozilla/5.0 (X11; Linux x86_64; rv:2.0b9pre) Gecko/20110111 Firefox/4.0b9pre", "Mozilla/5.0 (X11; Linux x86_64; rv:2.2a1pre) Gecko/20100101 Firefox/4.2a1pre", "Mozilla/5.0 (X11; Linux x86_64; rv:2.2a1pre) Gecko/20110324 Firefox/4.2a1pre", "Mozilla/5.0 (X11; Linux x86_64; rv:28.0) Gecko/20100101 Firefox/28.0", "Mozilla/5.0 (X11; Linux x86_64; rv:5.0) Gecko/20100101 Firefox/5.0 FirePHP/0.5", "Mozilla/5.0 (X11; Linux x86_64; rv:5.0) Gecko/20100101 Firefox/5.0 Firefox/5.0", "Mozilla/5.0 (X11; Linux) Gecko Firefox/5.0", "Mozilla/5.0 (X11; Mageia; Linux x86_64; rv:10.0.9) Gecko/20100101 Firefox/10.0.9", "Mozilla/5.0 (X11; NetBSD amd64; rv:16.0) Gecko/20121102 Firefox/16.0", "Mozilla/5.0 (X11; OpenBSD amd64; rv:28.0) Gecko/20100101 Firefox/28.0", "Mozilla/5.0 (X11; U; FreeBSD i386; de-CH; rv:1.9.2.8) Gecko/20100729 Firefox/3.6.8", "Mozilla/5.0 (X11; U; FreeBSD i386; en-US; rv:1.9.2.9) Gecko/20100913 Firefox/3.6.9", "Mozilla/5.0 (X11; U; Linux amd64; en-US; rv:5.0) Gecko/20110619 Firefox/5.0", "Mozilla/5.0 (X11; U; Linux amd64; rv:5.0) Gecko/20100101 Firefox/5.0 (Debian)", "Mozilla/5.0 (X11; U; Linux i586; de; rv:5.0) Gecko/20100101 Firefox/5.0", "Mozilla/5.0 (X11; U; Linux i686; de-DE; rv:1.9.2.8) Gecko/20100725 Gentoo Firefox/3.6.8", "Mozilla/5.0 (X11; U; Linux i686; en-GB; rv:2.0) Gecko/20110404 Fedora/16-dev Firefox/4.0", "Mozilla/5.0 (X11; U; Linux i686; en-US; rv:1.9.1.16) Gecko/20120421 Firefox/11.0", "Mozilla/5.0 (X11; U; Linux i686; en-US; rv:1.9.1.16) Gecko/20120421 Gecko Firefox/11.0", "Mozilla/5.0 (X11; U; Linux i686; en-US; rv:1.9.2.4) Gecko/20100625 Gentoo Firefox/3.6.4", "Mozilla/5.0 (X11; U; Linux i686; en-US; rv:1.9.2.7) Gecko/20100726 CentOS/3.6-3.el5.centos Firefox/3.6.7", "Mozilla/5.0 (X11; U; Linux i686; en-US; rv:1.9.2.8) Gecko/20100727 Firefox/3.6.8", "Mozilla/5.0 (X11; U; Linux i686; en-US; rv:1.9.2.9) Gecko/20100827 Red Hat/3.6.9-2.el6 Firefox/3.6.9", "Mozilla/5.0 (X11; U; Linux i686; fa; rv:1.8.1.4) Gecko/20100527 Firefox/3.6.4", "Mozilla/5.0 (X11; U; Linux i686; fi-FI; rv:1.9.2.8) Gecko/20100723 Ubuntu/10.04 (lucid) Firefox/3.6.8", "Mozilla/5.0 (X11; U; Linux i686; it-IT; rv:1.9.0.2) Gecko/2008092313 Ubuntu/9.25 (jaunty) Firefox/3.8", "Mozilla/5.0 (X11; U; Linux i686; pl-PL; rv:1.9.0.2) Gecko/2008092313 Ubuntu/9.25 (jaunty) Firefox/3.8", "Mozilla/5.0 (X11; U; Linux i686; pl-PL; rv:1.9.0.2) Gecko/20121223 Ubuntu/9.25 (jaunty) Firefox/3.8", "Mozilla/5.0 (X11; U; Linux i686; ru-RU; rv:1.9.2a1pre) Gecko/20090405 Ubuntu/9.04 (jaunty) Firefox/3.6a1pre", "Mozilla/5.0 (X11; U; Linux i686; ru; rv:1.9.1.3) Gecko/20091020 Ubuntu/10.04 (lucid) Firefox/4.0.1", "Mozilla/5.0 (X11; U; Linux i686; ru; rv:1.9.2.8) Gecko/20100723 Ubuntu/10.04 (lucid) Firefox/3.6.8", "Mozilla/5.0 (X11; U; Linux i686; ru; rv:1.9.3a5pre) Gecko/20100526 Firefox/3.7a5pre", "Mozilla/5.0 (X11; U; Linux i686; zh-CN; rv:1.9.2.8) Gecko/20100722 Ubuntu/10.04 (lucid) Firefox/3.6.8", "Mozilla/5.0 (X11; U; Linux x86_64; en-US; rv:1.9.2.4) Gecko/20100614 Ubuntu/10.04 (lucid) Firefox/3.6.4", "Mozilla/5.0 (X11; U; Linux x86_64; en-US; rv:1.9.2.6) Gecko/20100628 Ubuntu/10.04 (lucid) Firefox/3.6.6", "Mozilla/5.0 (X11; U; Linux x86_64; en-US; rv:1.9.2.6) Gecko/20100628 Ubuntu/10.04 (lucid) Firefox/3.6.6 (.NET CLR 3.5.30729)", "Mozilla/5.0 (X11; U; Linux x86_64; en-US; rv:1.9.2.6) Gecko/20100628 Ubuntu/10.04 (lucid) Firefox/3.6.6 GTB7.0", "Mozilla/5.0 (X11; U; Linux x86_64; en-US; rv:1.9.2.6) Gecko/20100628 Ubuntu/10.04 (lucid) Firefox/3.6.6 GTB7.1", "Mozilla/5.0 (X11; U; Linux x86_64; en-US; rv:1.9.2.7) Gecko/20100723 Fedora/3.6.7-1.fc13 Firefox/3.6.7", "Mozilla/5.0 (X11; U; Linux x86_64; en-US; rv:1.9.2.7) Gecko/20100809 Fedora/3.6.7-1.fc14 Firefox/3.6.7", "Mozilla/5.0 (X11; U; Linux x86_64; en-US; rv:1.9.2.8) Gecko/20100723 SUSE/3.6.8-0.1.1 Firefox/3.6.8", "Mozilla/5.0 (X11; U; Linux x86_64; en-US; rv:1.9.2.8) Gecko/20100804 Gentoo Firefox/3.6.8", "Mozilla/5.0 (X11; U; Linux x86_64; en-US; rv:1.9.2.9) Gecko/20100915 Gentoo Firefox/3.6.9", "Mozilla/5.0 (X11; U; Linux x86_64; en-US; rv:1.9.2a1pre) Gecko/20090405 Firefox/3.6a1pre", "Mozilla/5.0 (X11; U; Linux x86_64; en-US; rv:1.9.2a1pre) Gecko/20090428 Firefox/3.6a1pre", "Mozilla/5.0 (X11; U; Linux x86_64; pl-PL; rv:2.0) Gecko/20110307 Firefox/4.0", "Mozilla/5.0 (X11; U; OpenBSD i386; en-US; rv:1.9.2.8) Gecko/20101230 Firefox/3.6.8", "Mozilla/5.0 (X11; Ubuntu; Linux armv7l; rv:17.0) Gecko/20100101 Firefox/17.0", "Mozilla/5.0 (X11; Ubuntu; Linux i686; rv:14.0) Gecko/20100101 Firefox/14.0.1", "Mozilla/5.0 (X11; Ubuntu; Linux i686; rv:15.0) Gecko/20100101 Firefox/15.0.1", "Mozilla/5.0 (X11; Ubuntu; Linux x86_64; rv:14.0) Gecko/20100101 Firefox/14.0.1", "Mozilla/5.0 (X11; Ubuntu; Linux x86_64; rv:17.0) Gecko/20100101 Firefox/17.0.6", "Mozilla/5.0 (X11; Ubuntu; Linux x86_64; rv:21.0) Gecko/20100101 Firefox/21.0", "Mozilla/5.0 (X11; Ubuntu; Linux x86_64; rv:21.0) Gecko/20130331 Firefox/21.0", "Mozilla/5.0 (X11; Ubuntu; Linux x86_64; rv:24.0) Gecko/20100101 Firefox/24.0", "Mozilla/5.0 (compatible; Windows; U; Windows NT 6.2; WOW64; en-US; rv:12.0) Gecko/20120403211507 Firefox/12.0", "Mozilla/6.0 (Macintosh; I; Intel Mac OS X 11_7_9; de-LI; rv:1.9b4) Gecko/2012010317 Firefox/10.0a4", "Mozilla/6.0 (Windows NT 6.2; WOW64; rv:16.0.1) Gecko/20121011 Firefox/16.0.1", "Mozilla/3.0 (Windows NT 6.1; rv:2.0.1) Gecko/20100101 Firefox/5.0.1", Http.ChromeUserAgent, Http.FirefoxUserAgent}
    Dim STOOP As Integer = 0
    Public ISCUSTOM As Boolean = False
    Public L_GET As String = ""
    Public Links = New Queue(Of String)()
    Public Helper As New SLAYER_HELPER()
    Public ThreadP, ThreadG, ThreadY, ThreadB As Thread()
    '================================================================

    Public Sub New()
        InitializeComponent()
        CMResultat.SelectedIndex = 0
        CMType.SelectedIndex = 0
        text_proxyType.SelectedIndex = 3
        Me.Text = "SLAYER Leecher v0.7 [ " & Environment.UserName & " ]"
        Me.object_0 = RuntimeHelpers.GetObjectValue(New Object)
        CheckForIllegalCrossThreadCalls = False
        Me.CustomTabcontrol1.SelectedIndex = 0
        My.Settings.PROXYTYPE = 3
    End Sub

    Private Function indexUA() As Integer
        Return New Random().Next(0, 5)
    End Function
    '==============================================================================
    Private Function GNC() As String
        Return Me.CODE(Me.indexUA)
    End Function
    Private Function RandomAgent() As String
        Return File.ReadAllText(Application.StartupPath & "\UserAgents.txt")
    End Function

#Region "Background Workers"

    'Private Sub BackgroundWorker1_DoWork(sender As Object, e As DoWorkEventArgs) Handles BackgroundWorker1.DoWork
    '    Try
    '        Dim str As String
    '        Dim num As Integer = 1
    '        For Each str In Me.TextBox1.Text.Split(New Char() {ChrW(13)})
    '            Try
    '                Dim enumerator As IEnumerator
    '                Dim enumerator2 As IEnumerator
    '                Dim request As HttpWebRequest
    '                If ISCUSTOM Then
    '                    request = DirectCast(WebRequest.Create(String.Concat(New String() {"https://www.google." & GNC() & "/search?q=site:pastebin.com+", str, "&num=100&tbs=qdr:", Duréé})), HttpWebRequest)
    '                Else
    '                    request = DirectCast(WebRequest.Create(L_GET), HttpWebRequest)
    '                End If
    '                Dim response As HttpWebResponse = DirectCast(request.GetResponse, HttpWebResponse)
    '                Dim input As String = New StreamReader(response.GetResponseStream).ReadToEnd
    '                Dim str2 As String = input
    '                Me.RichTextBox2.Text = str2
    '                Dim matchs As MatchCollection = New Regex("(https\:\/\/pastebin\.com\/[a-zA-Z1-9]*)").Matches(RichTextBox2.Text)
    '                Dim builder As New StringBuilder
    '                Try
    '                    enumerator = matchs.GetEnumerator
    '                    Do While enumerator.MoveNext
    '                        builder.AppendLine(DirectCast(enumerator.Current, Match).ToString)
    '                    Loop
    '                Finally
    '                    If TypeOf enumerator Is IDisposable Then
    '                        TryCast(enumerator, IDisposable).Dispose()
    '                    End If
    '                End Try
    '                Me.TextBox3.Text = (Me.TextBox3.Text & builder.ToString)
    '                Dim matchs2 As MatchCollection = New Regex("(https\:\/\/pastebin\.com\/[a-zA-Z1-9]*)").Matches(RichTextBox2.Text)
    '                Dim builder2 As New StringBuilder
    '                Try
    '                    enumerator2 = matchs2.GetEnumerator
    '                    Do While enumerator2.MoveNext
    '                        builder2.AppendLine(DirectCast(enumerator2.Current, Match).ToString)
    '                    Loop
    '                Finally
    '                    If TypeOf enumerator2 Is IDisposable Then
    '                        TryCast(enumerator2, IDisposable).Dispose()
    '                    End If
    '                End Try
    '                Me.TextBox3.Text = (Me.TextBox3.Text & builder2.ToString)
    '                num += 1
    '                If BackgroundWorker1.CancellationPending Then
    '                    e.Cancel = True
    '                    Exit For
    '                End If

    '            Catch ex As Exception
    '                CR += 1
    '                CERR.Text = CR.ToString
    '                Continue For
    '            End Try
    '        Next
    '    Catch exception1 As Exception
    '        ProjectData.SetProjectError(exception1)
    '        Dim exception As Exception = exception1
    '        ProjectData.ClearProjectError()
    '    End Try
    'End Sub

    'Private Sub BackgroundWorker2_DoWork(sender As Object, e As DoWorkEventArgs) Handles BackgroundWorker2.DoWork
    '    Try
    '        Dim str As String
    '        For Each str In Me.TextBox1.Text.Split(New Char() {ChrW(13)})
    '            Try
    '                Dim enumerator As IEnumerator
    '                Dim enumerator2 As IEnumerator
    '                Dim REQ As New HttpRequest
    '                REQ.ConnectTimeout = 10000
    '                REQ.Proxy = Nothing
    '                REQ.AllowAutoRedirect = True
    '                REQ.KeepAlive = True
    '                REQ.IgnoreProtocolErrors = True
    '                Dim Input As String = REQ.Get("https://www.bing.com/search?q=site:pastebin.com+" & str + "&num=100&tbs=qdr:" + "y" + "&ei=-d2PUqnoIOyp7AbP2IGoBQ&start=" + Conversions.ToString(200) + "&sa=N&biw=1366&bih=604").ToString
    '                Me.RCHp.Text = Input
    '                Dim matchs As MatchCollection = New Regex("(https\:\/\/pastebin\.com\/[a-zA-Z1-9]*)").Matches(Me.RCHp.Text)
    '                Dim builder As New StringBuilder
    '                Try
    '                    enumerator = matchs.GetEnumerator
    '                    Do While enumerator.MoveNext
    '                        builder.AppendLine(DirectCast(enumerator.Current, Match).ToString)
    '                    Loop
    '                Finally
    '                    If TypeOf enumerator Is IDisposable Then
    '                        TryCast(enumerator, IDisposable).Dispose()
    '                    End If
    '                End Try
    '                Me.TextBox3.Text = (Me.TextBox3.Text & builder.ToString)
    '                Dim matchs2 As MatchCollection = New Regex("(https\:\/\/pastebin\.com\/[a-zA-Z1-9]*)").Matches(Me.RCHp.Text)
    '                Dim builder2 As New StringBuilder
    '                Try
    '                    enumerator2 = matchs2.GetEnumerator
    '                    Do While enumerator2.MoveNext
    '                        builder2.AppendLine(DirectCast(enumerator2.Current, Match).ToString)
    '                    Loop
    '                Finally
    '                    If TypeOf enumerator2 Is IDisposable Then
    '                        TryCast(enumerator2, IDisposable).Dispose()
    '                    End If
    '                End Try
    '                Me.TextBox3.Text = (Me.TextBox3.Text & builder2.ToString)

    '                If BackgroundWorker2.CancellationPending Then
    '                    e.Cancel = True
    '                    Exit For
    '                End If

    '            Catch ex As Exception
    '                Continue For
    '                CR += 1
    '                CERR.Text = CR.ToString
    '            End Try
    '        Next
    '    Catch exception1 As Exception
    '        ProjectData.SetProjectError(exception1)
    '        Dim exception As Exception = exception1
    '        ProjectData.ClearProjectError()
    '    End Try
    'End Sub

    'Private Sub BackgroundWorker3_DoWork(sender As Object, e As DoWorkEventArgs) Handles BackgroundWorker3.DoWork
    '    Try
    '        Dim str As String
    '        For Each str In Me.TextBox1.Text.Split(New Char() {ChrW(13)})
    '            Try
    '                Dim enumerator As IEnumerator
    '                Dim enumerator2 As IEnumerator
    '                Dim REQ As New HttpRequest
    '                REQ.ConnectTimeout = 10000
    '                REQ.Proxy = Nothing
    '                REQ.AllowAutoRedirect = True
    '                REQ.KeepAlive = True
    '                REQ.IgnoreProtocolErrors = True
    '                Dim str2 As String = REQ.Get(("http://www.google." & GNC() & "/search?q=" & str & "&num=100&tbs=qdr:" & Duréé & "&ei=-d2PUqnoIOyp7AbP2IGoBQ&start=50&sa=N&biw=1366&bih=604")).ToString
    '                Me.RichTextBox3.Text = str2
    '                Dim matchs As MatchCollection = New Regex("q=http://+(?:[a-zA-Z0-9./_+-]{3,})").Matches(Me.RichTextBox3.Text)
    '                Dim builder As New StringBuilder
    '                Try
    '                    enumerator = matchs.GetEnumerator
    '                    Do While enumerator.MoveNext
    '                        builder.AppendLine(DirectCast(enumerator.Current, Match).ToString)
    '                    Loop
    '                Finally
    '                    If TypeOf enumerator Is IDisposable Then
    '                        TryCast(enumerator, IDisposable).Dispose()
    '                    End If
    '                End Try
    '                Me.TextBox3.Text = (Me.TextBox3.Text & builder.ToString)
    '                Dim matchs2 As MatchCollection = New Regex("q=https://+(?:[a-zA-Z0-9./_+-]{3,})").Matches(Me.RichTextBox3.Text)
    '                Dim builder2 As New StringBuilder
    '                Try
    '                    enumerator2 = matchs2.GetEnumerator
    '                    Do While enumerator2.MoveNext
    '                        builder2.AppendLine(DirectCast(enumerator2.Current, Match).ToString)
    '                    Loop
    '                Finally
    '                    If TypeOf enumerator2 Is IDisposable Then
    '                        TryCast(enumerator2, IDisposable).Dispose()
    '                    End If
    '                End Try
    '                Me.TextBox3.Text = (Me.TextBox3.Text & builder2.ToString)

    '                If BackgroundWorker3.CancellationPending Then
    '                    e.Cancel = True
    '                    Exit For
    '                End If
    '            Catch ex As Exception
    '                Continue For
    '                CR += 1
    '                CERR.Text = CR.ToString
    '            End Try
    '        Next
    '    Catch exception1 As Exception
    '        ProjectData.SetProjectError(exception1)
    '        Dim exception As Exception = exception1
    '        ProjectData.ClearProjectError()
    '    End Try
    'End Sub

    'Private Sub BackgroundWorker4_DoWork(sender As Object, e As DoWorkEventArgs) Handles BackgroundWorker4.DoWork
    '    Try
    '        Dim str As String
    '        For Each str In Me.TextBox1.Text.Split(New Char() {ChrW(13)})
    '            Try
    '                Dim enumerator As IEnumerator
    '                Dim enumerator2 As IEnumerator
    '                Dim REQ As New HttpRequest
    '                REQ.ConnectTimeout = 10000
    '                REQ.Proxy = Nothing
    '                REQ.AllowAutoRedirect = True
    '                REQ.KeepAlive = True
    '                REQ.IgnoreProtocolErrors = True
    '                Dim str2 As String = REQ.Get(("https://duckduckgo.com/?q=site%3Apastebin.com+" & str & "&num=100&tbs=qdr:" & "w" & "&ei=-d2PUqnoIOyp7AbP2IGoBQ&start=" & Conversions.ToString(800) & "&sa=N&biw=1366&bih=604")).ToString
    '                Me.RichTextBox4.Text = str2
    '                Dim matchs As MatchCollection = New Regex("https://+(?:[a-zA-Z0-9./_+-]{3,})").Matches(Me.RichTextBox4.Text)
    '                Dim builder As New StringBuilder
    '                Try
    '                    enumerator = matchs.GetEnumerator
    '                    Do While enumerator.MoveNext
    '                        builder.AppendLine(DirectCast(enumerator.Current, Match).ToString)
    '                    Loop
    '                Finally
    '                    If TypeOf enumerator Is IDisposable Then
    '                        TryCast(enumerator, IDisposable).Dispose()
    '                    End If
    '                End Try
    '                Me.TextBox3.Text = (Me.TextBox3.Text & builder.ToString)
    '                Dim matchs2 As MatchCollection = New Regex("https://+(?:[a-zA-Z0-9./_+-]{3,})").Matches(Me.RichTextBox4.Text)
    '                Dim builder2 As New StringBuilder
    '                Try
    '                    enumerator2 = matchs2.GetEnumerator
    '                    Do While enumerator2.MoveNext
    '                        builder2.AppendLine(DirectCast(enumerator2.Current, Match).ToString)
    '                    Loop
    '                Finally
    '                    If TypeOf enumerator2 Is IDisposable Then
    '                        TryCast(enumerator2, IDisposable).Dispose()
    '                    End If
    '                End Try
    '                Me.TextBox3.Text = (Me.TextBox3.Text & builder2.ToString)

    '                If BackgroundWorker4.CancellationPending Then
    '                    e.Cancel = True
    '                    Exit For
    '                End If
    '            Catch ex As Exception
    '                Continue For
    '                CR += 1
    '                CERR.Text = CR.ToString
    '            End Try
    '        Next
    '    Catch exception1 As Exception
    '        ProjectData.SetProjectError(exception1)
    '        Dim exception As Exception = exception1
    '        ProjectData.ClearProjectError()
    '    End Try
    'End Sub

    'Private Sub BackgroundWorker5_DoWork(sender As Object, e As DoWorkEventArgs) Handles BackgroundWorker5.DoWork
    '    Try
    '        Dim str As String
    '        For Each str In Me.TextBox1.Text.Split(New Char() {ChrW(13)})
    '            Try
    '                Dim enumerator As IEnumerator
    '                Dim enumerator2 As IEnumerator
    '                Dim REQ As New HttpRequest
    '                REQ.ConnectTimeout = 10000
    '                REQ.Proxy = Nothing
    '                REQ.AllowAutoRedirect = True
    '                REQ.KeepAlive = True
    '                REQ.IgnoreProtocolErrors = True
    '                Dim str2 As String = REQ.Get(("https://yandex.ru/search/?text=" & str & "&start=50")).ToString
    '                Me.RichTextBox6.Text = str2
    '                Dim matchs2 As MatchCollection = New Regex("q=http://+(?:[a-zA-Z0-9./_+-]{3,})").Matches(Me.RichTextBox5.Text)
    '                Dim builder2 As New StringBuilder
    '                Try
    '                    enumerator = matchs2.GetEnumerator
    '                    Do While enumerator.MoveNext
    '                        builder2.AppendLine(DirectCast(enumerator.Current, Match).ToString)
    '                    Loop
    '                Finally
    '                    If TypeOf enumerator Is IDisposable Then
    '                        TryCast(enumerator, IDisposable).Dispose()
    '                    End If
    '                End Try
    '                Me.TextBox3.Text = (Me.TextBox3.Text & builder2.ToString)
    '                Dim matchs As MatchCollection = New Regex("q=https://+(?:[a-zA-Z0-9./_+-]{3,})").Matches(Me.RichTextBox5.Text)
    '                Dim builder As New StringBuilder
    '                Try
    '                    enumerator2 = matchs.GetEnumerator
    '                    Do While enumerator2.MoveNext
    '                        builder.AppendLine(DirectCast(enumerator2.Current, Match).ToString)
    '                    Loop
    '                Finally
    '                    If TypeOf enumerator2 Is IDisposable Then
    '                        TryCast(enumerator2, IDisposable).Dispose()
    '                    End If
    '                End Try
    '                Me.TextBox3.Text = (Me.TextBox3.Text & builder.ToString)

    '                If BackgroundWorker5.CancellationPending Then
    '                    e.Cancel = True : Exit For
    '                End If
    '            Catch ex As Exception
    '                Continue For
    '                CR += 1
    '                CERR.Text = CR.ToString
    '            End Try
    '        Next
    '    Catch exception1 As Exception
    '        ProjectData.SetProjectError(exception1)
    '        Dim exception As Exception = exception1
    '        ProjectData.ClearProjectError()
    '    End Try
    'End Sub

    'Private Sub BackgroundWorker6_DoWork(sender As Object, e As DoWorkEventArgs) Handles BackgroundWorker6.DoWork
    '    Try
    '        Dim str As String
    '        For Each str In Me.TextBox1.Text.Split(New Char() {ChrW(13)})
    '            Try
    '                Dim enumerator As IEnumerator
    '                Dim enumerator2 As IEnumerator
    '                Dim REQ As New HttpRequest
    '                REQ.ConnectTimeout = 10000
    '                REQ.Proxy = Nothing
    '                REQ.AllowAutoRedirect = True
    '                REQ.KeepAlive = True
    '                REQ.IgnoreProtocolErrors = True
    '                Dim str2 As String = REQ.Get(("http://www.bing.com/search?q=" & str & "&start=55")).ToString
    '                Me.RichTextBox5.Text = str2
    '                Dim matchs As MatchCollection = New Regex("q=http://+(?:[a-zA-Z0-9./_+-]{3,})").Matches(Me.RichTextBox6.Text)
    '                Dim builder As New StringBuilder
    '                Try
    '                    enumerator = matchs.GetEnumerator
    '                    Do While enumerator.MoveNext
    '                        builder.AppendLine(DirectCast(enumerator.Current, Match).ToString)
    '                    Loop
    '                Finally
    '                    If TypeOf enumerator Is IDisposable Then
    '                        TryCast(enumerator, IDisposable).Dispose()
    '                    End If
    '                End Try
    '                Me.TextBox3.Text = (Me.TextBox3.Text & builder.ToString)
    '                Dim matchs2 As MatchCollection = New Regex("q=https://+(?:[a-zA-Z0-9./_+-]{3,})").Matches(Me.RichTextBox6.Text)
    '                Dim builder2 As New StringBuilder
    '                Try
    '                    enumerator2 = matchs2.GetEnumerator
    '                    Do While enumerator2.MoveNext
    '                        builder2.AppendLine(DirectCast(enumerator2.Current, Match).ToString)
    '                    Loop
    '                Finally
    '                    If TypeOf enumerator2 Is IDisposable Then
    '                        TryCast(enumerator2, IDisposable).Dispose()
    '                    End If
    '                End Try
    '                Me.TextBox3.Text = (Me.TextBox3.Text & builder2.ToString)

    '                If BackgroundWorker6.CancellationPending Then
    '                    e.Cancel = True : Exit For
    '                End If
    '            Catch ex As Exception
    '                Continue For
    '                CR += 1
    '                CERR.Text = CR.ToString
    '            End Try
    '        Next
    '    Catch exception1 As Exception
    '        ProjectData.SetProjectError(exception1)
    '        Dim exception As Exception = exception1
    '        ProjectData.ClearProjectError()
    '    End Try
    'End Sub
#End Region


    Sub GrabData()
        Dim regex As New Regex("(https|http):\/\/+(?:[a-zA-Z0-9./_+-]{3,})")
        Dim matchs As MatchCollection = regex.Matches(TextBox3.Text)
        Dim builder As New StringBuilder
        Dim enumerator As IEnumerator = matchs.GetEnumerator
        Do While enumerator.MoveNext
            Dim current As Match = CType(enumerator.Current, Match)
            builder.AppendLine(current.ToString)
        Loop
        If TypeOf enumerator Is IDisposable Then
            TryCast(enumerator, IDisposable).Dispose()
        End If
        Me.TextBox4.Text = (Me.TextBox4.Text & builder.ToString).Trim
        Duplicates()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If (Me.TextBox1.Text = "") Then
            MsgBox("No Keywords Founded !", MsgBoxStyle.Critical, "X-SLAYER")
        Else
            '=====================================
            Button1.Enabled = False
            PictureBox2.Enabled = False
            CMResultat.Enabled = False
            GroupBox3.Enabled = False
            Button6.Enabled = True
            '=====================================
            Me.RichTextBox1.Clear()
            Me.RichTextBox2.Clear()
            Me.RichTextBox3.Clear()
            TextBox4.Clear()
            TextBox3.Clear()
            Me.TextBox2.Text = ""
            '=====================================

            Select Case My.Settings.PROXYTYPE
                Case 0
                    Helper.proxyType = proxyType.Http
                    Exit Select
                Case 1
                    Helper.proxyType = proxyType.Socks4
                    Exit Select
                Case 2
                    Helper.proxyType = proxyType.Socks5
                Case 3
                    Helper.UseProxy = False
                    Exit Select
                Case Else
                    MsgBox("Please select the type of proxy!", MsgBoxStyle.Information)
                    Return
            End Select
            Dim myQueue = New Queue(Of String)()
            For Each Keyword In Me.TextBox1.Text.Split(New Char() {ChrW(13)})
                myQueue.Enqueue(Keyword)
            Next
            Me.countThreads = Convert.ToInt32(Me.numericUpDown1.Value)

            Dim Searcher As New SLAYER_HELPER()

            If My.Settings.Pastebin = True Then
                Dim SLAYER As New Thread(New ThreadStart(Sub() Searcher.GetLinks(myQueue, "PASTEBIN", TextBox3, CERR)))
                SLAYER.IsBackground = True
                SLAYER.Start()
            End If
            If My.Settings.GOOGLE = True Then

                Dim SLAYER As New Thread(New ThreadStart(Sub() Searcher.GetLinks(myQueue, "GOOGLE", TextBox3, CERR)))
                SLAYER.IsBackground = True
                SLAYER.Start()
            End If
            If My.Settings.YANDEX = True Then
                Dim SLAYER As New Thread(New ThreadStart(Sub() Searcher.GetLinks(myQueue, "YAHOO", TextBox3, CERR)))
                SLAYER.IsBackground = True
                SLAYER.Start()
            End If
            If My.Settings.Bing = True Then
                Dim SLAYER As New Thread(New ThreadStart(Sub() Searcher.GetLinks(myQueue, "BING", TextBox3, CERR)))
                SLAYER.IsBackground = True
                SLAYER.Start()
            End If
            '=====================================
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If (TextBox3.Text = "") Then
            MsgBox("No data to filter.", MsgBoxStyle.Critical, Nothing)
        Else
            Dim enumerator As IEnumerator
            Dim enumerator2 As IEnumerator
            Me.TextBox3.Text = Me.TextBox3.Text.Replace("q=http://webcache.googleusercontent.com/search", "").Trim
            Me.TextBox3.Text = Me.TextBox3.Text.Replace("q=https://www.youtube.com/watch", "").Trim
            Dim matchs As MatchCollection = New Regex("https://+(?:[a-zA-Z0-9./_+-]{3,})").Matches(Me.TextBox3.Text)
            Dim builder As New StringBuilder
            Try
                enumerator = matchs.GetEnumerator
                Do While enumerator.MoveNext
                    builder.AppendLine(DirectCast(enumerator.Current, Match).ToString)
                Loop
            Finally
                If TypeOf enumerator Is IDisposable Then
                    TryCast(enumerator, IDisposable).Dispose()
                End If
            End Try
            Me.TextBox2.Text = (Me.TextBox2.Text & builder.ToString)
            Dim matchs2 As MatchCollection = New Regex("q=https://+(?:[a-zA-Z0-9./_+-]{3,})").Matches(Me.TextBox3.Text)
            Dim builder2 As New StringBuilder
            Try
                enumerator2 = matchs2.GetEnumerator
                Do While enumerator2.MoveNext
                    builder2.AppendLine(DirectCast(enumerator2.Current, Match).ToString)
                Loop
            Finally
                If TypeOf enumerator2 Is IDisposable Then
                    TryCast(enumerator2, IDisposable).Dispose()
                End If
            End Try
            Me.TextBox2.Text = (Me.TextBox2.Text & builder2.ToString)
            Interaction.MsgBox("Filtred Done Try To Grab Your Data", MsgBoxStyle.Information, Nothing)
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If (Me.TextBox2.Text = "") Then
            Interaction.MsgBox("Data Not Found!", MsgBoxStyle.Critical, Nothing)
        Else
            Me.Label3.Text = Me.TextBox2.Lines(0)
            Dim X As New Thread(AddressOf GrabData)
            X.Start()
            'Me.BackgroundWorker7.RunWorkerAsync()
        End If
    End Sub

    Public Sub Duplicates()
        Dim textLines = TextBox4.Text.Split(New String() {vbNewLine}, StringSplitOptions.RemoveEmptyEntries)
        Dim totalCount = textLines.Length
        Dim noDuplicateCount = textLines.Distinct().Count()
        Dim removedLinesCount = totalCount - noDuplicateCount
        TextBox4.Text = String.Join(vbNewLine, textLines.Distinct())
        MsgBox("Duplicate Removed", MsgBoxStyle.Information)

    End Sub


    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        '=====================================
        GroupBox3.Enabled = True
        CMResultat.Enabled = True
        Button1.Enabled = True
        PictureBox2.Enabled = True
        Button6.Enabled = False
        Helper.ForceStop = True
        '=====================================
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        If (Me.TextBox4.Text = "") Then
            Interaction.MsgBox("No Data To Save!", MsgBoxStyle.Critical, Nothing)
        Else
            Dim dialog As New SaveFileDialog With {
                .RestoreDirectory = True,
                .Filter = "TXT Files (*.txt)|*.txt",
                .FilterIndex = 1
            }
            dialog.ShowDialog()
            If (dialog.FileName <> Nothing) Then
                Using writer As StreamWriter = New StreamWriter(dialog.FileName)
                    writer.WriteLine(Me.TextBox4.Text)
                End Using
            End If
        End If
    End Sub
    Private Sub ConfigParDefaultToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ConfigParDefaultToolStripMenuItem.Click
        TextBox1.Text = My.Settings.Config
    End Sub

    Private Sub PastKeywordConfigToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PastKeywordConfigToolStripMenuItem.Click
        TextBox1.Text = Clipboard.GetText
    End Sub

    Private Sub ClearKeywordToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ClearKeywordToolStripMenuItem.Click
        TextBox1.Text = String.Empty
    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged
        Me.l6.Text = Conversions.ToString(Enumerable.Count(Of String)(Me.TextBox2.Lines))
    End Sub

    Private Sub TextBox3_TextChanged(sender As Object, e As EventArgs) Handles TextBox3.TextChanged
        Me.l5.Text = Conversions.ToString(Enumerable.Count(Of String)(Me.TextBox3.Lines))
    End Sub

    Private Sub TextBox4_TextChanged(sender As Object, e As EventArgs) Handles TextBox4.TextChanged
        Me.l8.Text = Conversions.ToString(Enumerable.Count(Of String)(Me.TextBox4.Lines))
    End Sub


    '--------------------------------------------------------Leeching Combos--------------------------------------------------------'

    Private Sub BTN1_Click(sender As Object, e As EventArgs) Handles BTN1.Click
        If (Me.countList = 0) Then
            MsgBox("No Links To Check !!", MsgBoxStyle.Exclamation)
            Exit Sub
        End If
        If (bproxy.Enabled And Me.countProxy = 0) Then
            MsgBox("Load Proxy Or Select NO PROXY", MsgBoxStyle.Exclamation)
            Exit Sub
        End If
        Select Case Me.text_proxyType.SelectedIndex
            Case 0
                Me.proxyType = proxyType.Http
                Exit Select
            Case 1
                Me.proxyType = proxyType.Socks4
                Exit Select
            Case 2
                Me.proxyType = proxyType.Socks5
            Case 3
                DAMN = "YES"
                Exit Select
            Case Else
                MsgBox("Please select the type of proxy!", MsgBoxStyle.Information)
                Return
        End Select
        Me.TXT2.Text = ""
        Button8.Enabled = False
        Button5.Enabled = True
        BTN1.Enabled = False
        BTNLoad.Enabled = False
        CMType.Enabled = False
        text_proxyType.Enabled = False
        bproxy.Enabled = False
        Me.total_checked = 0
        Me.total_errors = 0
        Me.goods = Nothing
        Me.lines = New Queue
        Dim i As Integer
        For i = 0 To Me.countList - 1
            Me.lines.Enqueue(Me.list(i))
        Next i
        Me.countThreads = Convert.ToInt32(Me.numericUpDown1.Value)
        Me.Thread = New Thread(Me.countThreads - 1) {}
        Dim j As Integer
        For j = 0 To Me.countThreads - 1
            Me.Thread(j) = New Thread(New ThreadStart(AddressOf Me.Fetch))
            Me.Thread(j).IsBackground = True
            Me.Thread(j).Start()
        Next j
        lbl9.ForeColor = Color.Green
        lbl9.Text = "Waiting For Crowling..."
        Me.updateStats.Enabled = True
        Me.BO = True
        STOOP = 1

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Button5.Enabled = False
        BO = False
        STOOP = 0
        Me.StopThreads()
        Me.updateStats.Enabled = False
        Me.BTN1.Enabled = True
        Button8.Enabled = True
        BTNLoad.Enabled = True
        CMType.Enabled = True
        text_proxyType.Enabled = True
        If Not Me.text_proxyType.SelectedIndex = 3 Then
            bproxy.Enabled = True
        End If
        lbl9.ForeColor = Color.Coral
        lbl9.Text = "Leeching Canceled X"
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        If (Me.TXT2.Text = "") Then
            MsgBox("No Data To Save", MsgBoxStyle.Critical, Nothing)
        Else
            Dim B As New SaveFileDialog
            Dim i As Integer
            B.Filter = "txt files (*.txt)|*.txt"
            B.Title = "Save Results"
            B.FileName = ""
            If B.ShowDialog = DialogResult.OK Then
                File.WriteAllLines(B.FileName, TXT2.Lines)
            End If
            MsgBox("Saved To : " & B.FileName, MsgBoxStyle.Information, "SLAYER Leecher v0.6")
        End If
    End Sub

    Private Sub TXT1_TextChanged(sender As Object, e As EventArgs)
        '  Me.lbl3.Text = Conversions.ToString(Enumerable.Count(Of String)(Me.TXT1.Lines))
    End Sub


    Private Sub BTNLoad_Click(sender As Object, e As EventArgs) Handles BTNLoad.Click
        Using dialog As OpenFileDialog = New OpenFileDialog
            dialog.Filter = "Тext Files|*.txt"
            If (dialog.ShowDialog = DialogResult.OK) Then
                Dim separator As Char() = New Char() {ChrW(10)}
                Me.list = Enumerable.ToArray(Of String)(Enumerable.Distinct(Of String)(File.ReadAllText(dialog.FileName).Trim.TrimEnd.Replace(";", ":").Split(separator)))
                Me.countList = Me.list.Length
                Me.lbl3.Text = Me.countList.ToString
                BTNLoad.Text = "Loaded List: " & Me.countList.ToString()
            End If
        End Using
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs)
        TextBox3.Copy()
    End Sub

    Private Sub LinkLabel3_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel3.LinkClicked
        Process.Start("https://www.youtube.com/channel/UCNhHoOMBv2pgAKduePC0_Fg?sub_confirmation=1")
    End Sub

    Private Sub LinkLabel2_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel2.LinkClicked
        Process.Start("https://twitter.com/IHEB_X_SLAYER")
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Process.Start("https://www.facebook.com/iih3b")
    End Sub

    Private Sub Button9_Click_1(sender As Object, e As EventArgs) Handles Button9.Click
        TXT2.Clear()
    End Sub

    Public Sub Remove()
        Try
            Dim textLines = TXT2.Lines
            Dim totalCount = textLines.Length
            Dim noDuplicateCount = textLines.Distinct().Count()
            Dim removedLinesCount = totalCount - noDuplicateCount
            TXT2.Text = String.Join(vbNewLine, textLines.Distinct())
            MsgBox("Duplicate Removed", MsgBoxStyle.Information)
        Catch ex As Exception
        End Try
    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        Dim Iheb As New Thread(AddressOf Remove)
        Iheb.Start()
    End Sub

    Private Sub CMResultat_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CMResultat.SelectedIndexChanged

        If CMResultat.SelectedIndex = 0 Then
            Duréé = "all"
        ElseIf CMResultat.SelectedIndex = 1 Then
            Duréé = "y"
        ElseIf CMResultat.SelectedIndex = 2 Then
            Duréé = "m"
        ElseIf CMResultat.SelectedIndex = 3 Then
            Duréé = "w"
        ElseIf CMResultat.SelectedIndex = 4 Then
            Duréé = "d"
        ElseIf CMResultat.SelectedIndex = 5 Then
            Custom.ShowDialog()
        Else
            Duréé = "all"
        End If
    End Sub


    '--------------------------------------------------------Check Update-------------------------------------------------------'
    Sub UpToDate()


        Try

            imgversion.Image = My.Resources.loading_gif

            Dim version As String = "0.7"

            Dim down As New Net.WebClient

            Dim checkver As String = down.DownloadString("https://pastebin.com/raw/NPNC4LYX")

            If Not checkver.Split("|")(0) = version Then

                imgversion.Image = My.Resources.NewVersion

                lnews.Text = "New version Has Been Updated"

                lblyes.Text = "New Version Updated With New Features"

                If MsgBox("New Version Updated" & Chr(13) & "Do You Want To Check", MsgBoxStyle.YesNo, "X-SLAYER") = MsgBoxResult.Yes Then

                    Process.Start(checkver.Split("|")(1))

                End If
            Else
                imgversion.Image = My.Resources.shopping_cart_accept_icon

                lnews.Text = "This version Is Up-To-Date"

                lblyes.Text = "No Version Updated "
            End If

        Catch ex As Exception

            MsgBox("Your Connexion Low To Check For Updates", MsgBoxStyle.Exclamation)
            imgversion.Image = My.Resources.shopping_cart_accept_icon

        End Try
    End Sub

    '--------------------------------------------------------Update-------------------------------------------------------'

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
        Dim ThreadUP As New Thread(AddressOf UpToDate)
        ThreadUP.SetApartmentState(ApartmentState.STA)
        ThreadUP.Start()
    End Sub


    Private Sub Form1_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        Dim ThreadUP As New Thread(AddressOf UpToDate)
        ThreadUP.SetApartmentState(ApartmentState.STA)
        ThreadUP.Start()
    End Sub

#Region "LEECHING"

    Private Function RandomUA() As String
        Return UAList(rUA)
    End Function
    Private Function rUA() As Integer
        Return New Random().Next(0, 251)
    End Function

    Public Sub Fetch()

        Do While (lines.Count <> 0)
            If Not DAMN = "YES" Then
                proxyAddress = Me.proxy(Me.rnd.Next(0, Me.countProxy))
            End If
            Dim str2 As String = ""
            Dim lockThis As Object = RuntimeHelpers.GetObjectValue(Me.lockThis)
            ObjectFlowControl.CheckForSyncLockOnValueType(lockThis)
            Dim objectValue As Object = RuntimeHelpers.GetObjectValue(Me.object_0)
            Dim lockTaken As Boolean = False
            Dim obj3 As Object = New Object()

            Try
                Dim obj4 As Object = RuntimeHelpers.GetObjectValue(objectValue)
                obj3 = RuntimeHelpers.GetObjectValue(obj4)
                Monitor.Enter(RuntimeHelpers.GetObjectValue(obj4), lockTaken)
                Try
                    str2 = Me.lines.Peek.ToString.TrimEnd(New Char() {ChrW(13)}).Trim
                    Me.lines.Dequeue()
                Catch exception1 As Exception
                    ProjectData.SetProjectError(exception1)
                    Dim exception As Exception = exception1
                    ProjectData.ClearProjectError()
                End Try
            Finally
                If lockTaken Then
                    Monitor.Exit(RuntimeHelpers.GetObjectValue(obj3))
                End If
            End Try
            Try
                Using request As HttpRequest = New HttpRequest
                    Dim dictionary As New CookieDictionary(False)
                    If DAMN = "YES" Then
                        request.Proxy = Nothing
                    Else
                        request.Proxy = ProxyClient.Parse(Me.proxyType, proxyAddress)
                    End If
                    request.Cookies = dictionary
                    request.AllowAutoRedirect = True
                    request.KeepAlive = True
                    request.IgnoreProtocolErrors = True
                    request.UserAgent = RandomUA()

                    Dim response As String = request.Get(str2, Nothing).ToString()
                    lockThis = Me.lockThis
                    SyncLock lockThis
                        If BO Then
                            SLAYER(response, Pitter)
                        End If
                    End SyncLock
                    total_checked += 1
                End Using
                If BO = False Then
                    Exit Do
                End If
            Catch obj1 As Exception
                total_errors += 1
                Me.lines.Enqueue(str2)
                If Not DAMN = "YES" Then
                    proxyAddress = Me.proxy(Me.rnd.Next(0, Me.countProxy))
                End If
                Continue Do
            End Try
        Loop
        If total_checked >= countList Then
            BO = False
            Exit Sub
        End If
    End Sub

    Public Sub SLAYER(ByVal response As String, ByVal pattern As String)
        Dim regex As New Regex(pattern)
        Dim matchs As MatchCollection = regex.Matches(response)
        Dim builder As New StringBuilder
        Dim enumerator As IEnumerator = matchs.GetEnumerator
        Do While enumerator.MoveNext
            Dim current As Match = CType(enumerator.Current, Match)
            builder.AppendLine(current.ToString)
        Loop
        If TypeOf enumerator Is IDisposable Then
            TryCast(enumerator, IDisposable).Dispose()
        End If
        Me.TXT2.Text = (Me.TXT2.Text & builder.ToString).Trim
        response = Nothing
    End Sub


    '----------------------------------------------------------
    Public Sub StopThreads()
        Dim i As Integer
        For i = 0 To Me.countThreads - 1
            Me.Thread(i) = New Thread(New ThreadStart(AddressOf Me.Fetch))
            Me.Thread(i).IsBackground = True
            Me.Thread(i).Abort()
            BO = False
        Next i
    End Sub
    '----------------------------------------------------------
#End Region

    '([a-zA-Z0-9._%+-]{4,4}\-[a-zA-Z0-9._%+-]{4,4}\-[a-zA-Z0-9._%+-]{4,4}\-[a-zA-Z0-9._%+-]{4,4}-[a-zA-Z0-9._%+-]{4,4})
    Private Sub TXT1_TextChanged_1(sender As Object, e As EventArgs)
        'Me.lbl3.Text = Conversions.ToString(Enumerable.Count(Of String)(Me.TXT1.Lines))
    End Sub

    Private Sub CMType_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CMType.SelectedIndexChanged
        If CMType.SelectedIndex = 0 Then
            Pitter = "[a-zA-Z0-9._%+-]+@(?:[a-zA-Z0-9-]+\.)+[a-zA-Z]{2,6}:(?:[a-zA-Z0-9]{5,})"
        ElseIf CMType.SelectedIndex = 1 Then
            Pitter = "[a-zA-Z0-9._%+-]+@(?:[a-zA-Z0-9-]+\.)+[a-zA-Z]{2,6}"
        ElseIf CMType.SelectedIndex = 2 Then
            Pitter = "([\w+]{3,10}\:[\w+]{3,10})"
        Else
            Dim SL As String = InputBox("Add A Specific Regex", "Specific Regex", "")
            If SL = String.Empty Then
                CMType.SelectedIndex = 0
                Pitter = "[a-zA-Z0-9._%+-]+@(?:[a-zA-Z0-9-]+\.)+[a-zA-Z]{2,6}:(?:[a-zA-Z0-9]{5,})"
            Else
                Pitter = SL
            End If
        End If
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Search_Engine.ShowDialog()
    End Sub

    Private Sub PictureBox2_MouseEnter(sender As Object, e As EventArgs) Handles PictureBox2.MouseEnter
        Me.PictureBox2.Image = My.Resources.s2
    End Sub

    Private Sub PictureBox2_MouseLeave(sender As Object, e As EventArgs) Handles PictureBox2.MouseLeave
        Me.PictureBox2.Image = My.Resources.s3
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs)
        If Me.TextBox4.Text <> String.Empty Then
            Dim separator As Char() = New Char() {ChrW(10)}
            Me.list = Enumerable.ToArray(Of String)(Enumerable.Distinct(Of String)(File.ReadAllText(TextBox4.Text).Trim.TrimEnd.Replace(";", ":").Split(separator)))
            Me.countList = Me.list.Length
            Me.lbl3.Text = Me.countList.ToString
            Me.CustomTabcontrol1.SelectedTab = Me.TabPage2
        Else
            MsgBox("No Links To Leech", MsgBoxStyle.Information)
        End If
    End Sub

    Private Sub LinkLabel4_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel4.LinkClicked
        Clipboard.SetText("1BwmJGbs7gJXHE4wfYbBhqBQQpFbCaKY9j")
    End Sub

    Private Sub updateStats_Tick(sender As Object, e As EventArgs) Handles updateStats.Tick
        Me.l12.Text = Me.total_checked.ToString
        Me.err.Text = Me.total_errors.ToString
    End Sub

    Private Sub TXT2_TextChanged_1(sender As Object, e As EventArgs) Handles TXT2.TextChanged
        On Error Resume Next
        Application.DoEvents()
        Me.lblc.Text = Conversions.ToString(Enumerable.Count(Of String)(Me.TXT2.Lines))
        Me.TXT2.Select(Me.TXT2.Text.Length, 0)
        Me.TXT2.ScrollToCaret()
    End Sub

    Private Sub BTNLoad_DragDrop(sender As Object, e As DragEventArgs) Handles BTNLoad.DragDrop
        Dim separator As Char() = New Char() {ChrW(10)}
        Me.list = Enumerable.ToArray(Of String)(Enumerable.Distinct(Of String)(File.ReadAllText(e.Data.GetData(DataFormats.FileDrop)(0)).Trim.TrimEnd.Replace(";", ":").Split(separator)))
        Me.countList = Me.list.Length
        Me.lbl3.Text = Me.countList.ToString
    End Sub

    Private Sub BTNLoad_DragEnter(sender As Object, e As DragEventArgs) Handles BTNLoad.DragEnter
        If e.Data.GetDataPresent(DataFormats.FileDrop) Then
            e.Effect = DragDropEffects.All
        End If
    End Sub

    Private Sub Button4_Click_1(sender As Object, e As EventArgs) Handles Button4.Click
        On Error Resume Next
        Dim PATHH As String = Path.GetTempPath() & "passtoleecher.txt"
        If File.Exists(PATHH) Then
            File.Delete(PATHH)
        End If
        File.WriteAllText((PATHH), TextBox4.Text)
        Dim separator As Char() = New Char() {ChrW(10)}
        Me.list = Enumerable.ToArray(Of String)(Enumerable.Distinct(Of String)(File.ReadAllText(PATHH).Trim.TrimEnd.Replace(";", ":").Split(separator)))
        Me.countList = Me.list.Length
        Me.lbl3.Text = Me.countList.ToString()
        BTNLoad.Text = "Loaded List: " & Me.countList.ToString()
        Me.CustomTabcontrol1.SelectedIndex = 1
        File.Delete(PATHH)
    End Sub

    Private Sub bproxy_Click(sender As Object, e As EventArgs) Handles bproxy.Click
        Using dialog As OpenFileDialog = New OpenFileDialog
            dialog.Filter = "Text Files|*.txt"
            If (dialog.ShowDialog = DialogResult.OK) Then
                Me.proxy = Enumerable.ToArray(Of String)(Enumerable.Distinct(Of String)(File.ReadAllLines(dialog.FileName)))
                Me.countProxy = Me.proxy.Length
                Me.bproxy.Text = ("Loaded Proxy: " & Me.countProxy.ToString)
            End If
        End Using
    End Sub

    Private Sub bproxy_DragDrop(sender As Object, e As DragEventArgs) Handles bproxy.DragDrop
        Me.proxy = Enumerable.ToArray(Of String)(Enumerable.Distinct(Of String)(File.ReadAllLines(e.Data.GetData(DataFormats.FileDrop)(0))))
        Me.countProxy = Me.proxy.Length
        Me.bproxy.Text = ("Loaded Proxy: " & Me.countProxy.ToString)
    End Sub

    Private Sub bproxy_DragEnter(sender As Object, e As DragEventArgs) Handles bproxy.DragEnter
        If e.Data.GetDataPresent(DataFormats.FileDrop) Then
            e.Effect = DragDropEffects.All
        End If
    End Sub

    Private Sub text_proxyType_SelectedIndexChanged(sender As Object, e As EventArgs) Handles text_proxyType.SelectedIndexChanged
        If Me.text_proxyType.SelectedIndex = 3 Then
            bproxy.Enabled = False
        Else
            bproxy.Enabled = True
        End If
    End Sub

    Private Sub PictureBox1_MouseEnter(sender As Object, e As EventArgs) Handles PictureBox1.MouseEnter
        PictureBox1.Visible = False
    End Sub

    Private Sub PictureBox1_MouseLeave(sender As Object, e As EventArgs) Handles PictureBox1.MouseLeave
        PictureBox1.Visible = True
    End Sub

    Private Sub CustomTabcontrol1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CustomTabcontrol1.SelectedIndexChanged
        If (Me.CustomTabcontrol1.SelectedIndex = 2) Then
            Try
                My.Computer.Audio.Play(My.Resources.credit, AudioPlayMode.BackgroundLoop)
            Catch ex As Exception
            End Try
        Else
            My.Computer.Audio.Stop()
        End If
    End Sub

    Private Sub LinkLabel5_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel5.LinkClicked
        Process.Start("https://www.facebook.com/iih3b")
    End Sub
End Class
