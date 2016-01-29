//
//  ViewController.m
//  phones
//
//  Created by z on 1/26/16.
//  Copyright © 2016 z. All rights reserved.
//

#import "MainViewController.h"
#import "DetailViewController.h"
#import "GSMList.h"

@interface MainViewController ()

@property NSInteger chosenCellIndex;

@end

@implementation MainViewController


- (void)viewDidLoad {
    [super viewDidLoad];
    
    if (self.gsm !=nil) {
        [phones addObject:self.gsm];
    }
    
    [self.tableViewPhones setDataSource:self];
    [self.tableViewPhones setDelegate:self];    
}

- (void)didReceiveMemoryWarning {
    [super didReceiveMemoryWarning];
    // Dispose of any resources that can be recreated.
}

-(NSInteger)tableView:(UITableView *)tableView numberOfRowsInSection:(NSInteger)section{
    return phones.count;
}

-(UITableViewCell *)tableView:(UITableView *)tableView cellForRowAtIndexPath:(NSIndexPath *)indexPath{
    
    NSArray *cellIdentifiers = @[@"oddCell",@"evenCell"];
    
    NSString *cellIdentifier = cellIdentifiers[indexPath.row%2];
    
    UITableViewCell *cell = [tableView dequeueReusableCellWithIdentifier:cellIdentifier];
    
    if (cell==nil) {
        cell = [[UITableViewCell alloc] initWithStyle:UITableViewCellStyleDefault reuseIdentifier:cellIdentifier];
    }
    
    cell.textLabel.text = [phones[indexPath.row] description];
    
    return cell;
}

-(void)tableView:(UITableView *)tableView didSelectRowAtIndexPath:(NSIndexPath *)indexPath{
    
    self.chosenCellIndex = indexPath.row;
    
    [self performSegueWithIdentifier:@"detailSegue" sender:tableView];
}

-(void)prepareForSegue:(UIStoryboardSegue *)segue sender:(id)sender{
    
    NSString* detailSegueIdentifier = @"detailSegue";
    
    if ([segue.identifier isEqualToString:detailSegueIdentifier]) {
        DetailViewController* toVC = segue.destinationViewController;
        GSM *gsmToSend = phones[self.chosenCellIndex];
        toVC.gsm = gsmToSend;
    }
}

@end
