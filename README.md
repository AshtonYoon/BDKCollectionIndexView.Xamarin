# BDKCollectionIndexView

An index-title-scrubber-bar, for use with a UICollectionView or as a replacement for the one provided by a UITableView. Gives a collection/table view the index title bar for -sectionIndexTitles that a UITableView gets for (almost) free.

# Usage

To install it via [Nuget](https://www.nuget.org/packages/BDKCollectionIndexView.Xamarin/)

![](https://github.com/AshtonYoon/BDKCollectionIndexView.Xamarin/blob/master/Screen%20Shots/Screen%20Shot%202020-04-19%20at%202.17.58%20AM.png)

or command line

```
Install-Package BDKCollectionIndexView.Xamarin -Version 1.0.2
```

And then add it as a subview of whatever view contains your tableView or collectionView (but not the tableView or collectionView itself). Then assign it a width value of 28 (or height, if you're using it as a horizontal index view). Attach whatever other layout constraints you see fit!

``` C#
using CoreGraphics;

// Then assign it a width value of 28 (or height, if you're using it as a horizontal index view). Attach whatever other layout constraints you see fit!
int indexWidth = 28;
var size = containerView.Frame;
var frame = new CGRect(size.Width - indexWidth, 0, indexWidth, size.Height);

var indexView = new BDKCollectionIndexView(frame, titles)
{
    AutoresizingMask = UIViewAutoresizing.FlexibleWidth | UIViewAutoresizing.FlexibleHeight,
    BackgroundColor = UIColor.Clear,
    TouchStatusViewAlpha = 0f,
    TintColor = UIColor.White,
};

indexView.ValueChanged += (sender, e) =>
{
    var indexView = sender as BDKCollectionIndexView;
    var path = NSIndexPath.FromRowSection(0, (int)indexView.CurrentIndex);
    collectionView.ScrollToItem(path, UICollectionViewScrollPosition.Top, false);

    // If you're using a collection view, bump the y-offset by a certain number of points
    // because it won't otherwise account for any section headers you may have.
    collectionView.ContentOffset = new CGPoint(x: collectionView.ContentOffset.X, y: collectionView.ContentOffset.Y - 45.0);
};
```
