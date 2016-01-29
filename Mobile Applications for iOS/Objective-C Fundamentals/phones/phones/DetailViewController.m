//
//  DetailViewController.m
//  phones
//
//  Created by z on 1/28/16.
//  Copyright © 2016 z. All rights reserved.
//

#import "DetailViewController.h"

@interface DetailViewController ()

@end

@implementation DetailViewController

- (void)viewDidLoad {
    [super viewDidLoad];
    [self.modelData setText:self.gsm.model];
    [self.manufacturerData setText:self.gsm.manufacturer];
    [self.ownerData setText:self.gsm.owner];
    [self.priceData setText:[NSString stringWithFormat:@"%f",self.gsm.price]];
    [self.batteryData setText:[self.gsm.battery description]];
    [self.displayData setText:[self.gsm.display description]];
}

- (void)didReceiveMemoryWarning {
    [super didReceiveMemoryWarning];
    // Dispose of any resources that can be recreated.
}

/*
#pragma mark - Navigation

// In a storyboard-based application, you will often want to do a little preparation before navigation
- (void)prepareForSegue:(UIStoryboardSegue *)segue sender:(id)sender {
    // Get the new view controller using [segue destinationViewController].
    // Pass the selected object to the new view controller.
}
*/

@end
