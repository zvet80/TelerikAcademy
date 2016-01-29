//
//  DetailViewController.h
//  phones
//
//  Created by z on 1/28/16.
//  Copyright © 2016 z. All rights reserved.
//

#import <UIKit/UIKit.h>
#import "GSM.h"

@interface DetailViewController : UIViewController
@property GSM* gsm;
@property (weak, nonatomic) IBOutlet UITextField *modelData;
@property (weak, nonatomic) IBOutlet UITextField *manufacturerData;
@property (weak, nonatomic) IBOutlet UITextField *ownerData;
@property (weak, nonatomic) IBOutlet UITextField *priceData;
@property (weak, nonatomic) IBOutlet UITextField *batteryData;
@property (weak, nonatomic) IBOutlet UITextField *displayData;

@end
