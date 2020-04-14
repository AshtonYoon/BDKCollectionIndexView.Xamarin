BDKCollectionIndexView.Xamarin

Simple usage

```
int indexWidth = 28;
var size = containerView.Frame;
var frame = new CGRect(size.Width - indexWidth, 0, indexWidth, size.Height);
var indexView = new BDKCollectionIndexView(frame, titles)
{
    AutoresizingMask = UIViewAutoresizing.FlexibleWidth | UIViewAutoresizing.FlexibleHeight,
    IndexTitles = titles,
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

return indexView;
```
