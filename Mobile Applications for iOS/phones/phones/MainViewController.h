//
//  ViewController.h
//  phones
//
//  Created by z on 1/26/16.
//  Copyright © 2016 z. All rights reserved.
//

#import <UIKit/UIKit.h>
#import "GSM.h"

@interface MainViewController : UIViewController<UITableViewDelegate,UITableViewDataSource>


@property GSM* gsm;
@property (weak, nonatomic) IBOutlet UITableView *tableViewPhones;

@end

